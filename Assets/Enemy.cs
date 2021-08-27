using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool shootme = false;

    public float speed;
    public bool gethit = false;
	public int health = 100;
    public Animator EnemyPlayer;
    //	public GameObject deathEffect;
    public Transform other;
    public bool caughtme = false;
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void TakeDamage (int damage)
	{
     
        health -= damage;

		if (health <= 0)
		{
			Die();
		}
      
    }
     void Update()
    {
        if (shootme)
        {
            Shoot();
            shootme = false;
        }

        if (caughtme)
        {
            shootme = true;
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, other.position, step);
        }
        else if (!caughtme) {
            shootme = false;
            float step = 0 * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, other.position, step);
        }
        float dist = Vector3.Distance(other.position, transform.position);
        Debug.Log("Distance" + dist);
        if (dist >= 170f)
        {
            caughtme = false;
         
        }
        else if (dist < 170f) {
            caughtme = true;

        }

        if (gethit)
        {
            EnemyPlayer.SetBool("Hit", true);
            EnemyPlayer.SetBool("Idle", false);
            gethit = false;
        }
        else {
            EnemyPlayer.SetBool("Hit", false);
            EnemyPlayer.SetBool("Idle", true);
        }
    }
    void Die ()
	{
        //	Instantiate(deathEffect, transform.position, Quaternion.identity);
        EnemyPlayer.SetBool("Die", true);
        EnemyPlayer.SetBool("Idle", false);
        
        Destroy(gameObject,2f);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet") {
            TakeDamage(10);
            gethit = true;
        
        }
    }

}
