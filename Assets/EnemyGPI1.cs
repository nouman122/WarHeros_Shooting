using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyGPI1 : MonoBehaviour
{
    public GameObject blasteffect;
    public GameObject Parent;
    public bool gethit = false;
    public int health = 100;
    public Animator EnemyPlayer;
    public Transform other;
    public bool caughtme = false;
    public AIPath aiPath;
    public Animator enemyCOntrol;
    public bool diemme = false;
    public static bool enemycount = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (diemme) {
            EnemyPlayer.SetBool("Die", true);
            EnemyPlayer.SetBool("Hit", false);
            enemyCOntrol.SetBool("Attack", false);
            enemyCOntrol.SetBool("Walk", false);
        }
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f) {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        float dist = Vector3.Distance(other.position, transform.position);
       // Debug.Log("Distance" + dist);
        if (dist >= 170f)
        {
            caughtme = false;

        }
        else if (dist < 170f && !diemme)
        {
            caughtme = true;

        }

        if (caughtme && !diemme)
        {
            enemyCOntrol.SetBool("Walk", false);
            enemyCOntrol.SetBool("Idle", false);
            enemyCOntrol.SetBool("Attack", true);
        }
        else if (!caughtme && !diemme) {
            enemyCOntrol.SetBool("Walk", true);
            enemyCOntrol.SetBool("Idle", false);
            enemyCOntrol.SetBool("Attack", false);
        }

        if (gethit)
        {
            EnemyPlayer.SetBool("Hit", true);
            enemyCOntrol.SetBool("Attack", false);
            enemyCOntrol.SetBool("Walk", false);
            gethit = false;
        }
        else if (!gethit)
        {
            EnemyPlayer.SetBool("Hit", false);
        }

    }
    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
        {
            Die();
            enemycount = true;
        }

    }
    void Die()
    {
        diemme = true;
        caughtme = false;
        //	Instantiate(deathEffect, transform.position, Quaternion.identity);
    
        caughtme = false;
        blasteffect.SetActive(true);
      
        Destroy(Parent, 0.1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            TakeDamage(100);
            gethit = true;

        }
    }
}
