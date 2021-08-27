using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairMovement : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-4, 0, 0);
    private Vector3 pos2 = new Vector3(4, 0, 0);
    public float speed;
    public Joystick joystick;
    Quaternion targetRotation;
    public GameObject PlayerFace;
    public GameObject Knob;
    // Start is called before the first frame update
    void Start()
    {
        joystick = GameObject.FindWithTag("Joystick").GetComponent<FixedJoystick>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x > 10)
        //    transform.position = new Vector3(20, transform.position.y, transform.position.z);
        //if (transform.position.x < -10)
        //    transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        // if (PlayerFace.transform.localRotation > 180f)
        // {
        //     PlayerFace.GetComponent<SpriteRenderer>().flipX = true;

        // }
        //else if (joystick.Horizontal < 180)
        // {
        //     PlayerFace.GetComponent<SpriteRenderer>().flipX = false;

        // }
        transform.GetComponent<Rigidbody2D>().velocity=new Vector2(joystick.Horizontal * speed
            , joystick.Vertical * speed);
    }
}
