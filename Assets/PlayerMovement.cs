using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject GameOverPanel;
    public bool hitenemy = false;
    public static float healthAmount;
    public GameObject[] blockers;
    public GameObject crosshair;
    public CharacterController2D controller;
    public Joystick joystick;
    public Joystick joystick1;
    public float runspeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public Animator player;
    public PhysicsMaterial2D nofriction, withfriction;
    // Start is called before the first frame update
    void Start()
    {
        healthAmount = 0.6236283f;
    }

    // Update is called once per frame
    void Update()
    {

        if (joystick.Horizontal >= 0.2f)
        {
            blockers[0].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[1].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[3].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            crosshair.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
          
            horizontalMove = runspeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            blockers[0].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[1].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            blockers[3].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            crosshair.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
         
            horizontalMove = -runspeed;
        }
        else {
          
            horizontalMove = 0f;
            blockers[0].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            blockers[1].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            blockers[2].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            blockers[3].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            crosshair.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
        }
        player.SetFloat("Speed", Mathf.Abs(horizontalMove));
        float verticalMove = joystick.Vertical;
        if (verticalMove >= 0.5f)
        {
          
            jump = true;
            player.SetBool("IsJumping", true);
        }
   
       
    }
    public void OnLanding()
    {
        player.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {
        if (hitenemy) {
            Debug.Log("Enemy");
            healthAmount -= 0.1f;
            hitenemy = false;
        }
        if (healthAmount <= 0)
        {
            this.gameObject.SetActive(false);
            Invoke("Over", 0.3f);
        }
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");
            hitenemy = true;
          

        }
    }
    public void Over()
    {
        GameOverPanel.SetActive(true);
    }
}
