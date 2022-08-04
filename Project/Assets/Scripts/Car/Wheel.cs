using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

    WheelJoint2D wheel;
    public float carSpeed;
    bool onGround;
    float z;
    //Transform parentTransform;

    private void Awake()
    {
        //parentTransform = transform.parent;
        wheel = GetComponent<WheelJoint2D>();
    }

    void Update()
    {


        if (onGround)
        {
            MoveOnGround();
        }
        //else
        //{
        //    RotateInAir();
        //}

    

    }

    //private void FixedUpdate()
    //{
    //    parentTransform.rotation = Quaternion.Euler(0, 0, z);
    //}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }


    private void MoveOnGround()
    {

        float speed = 0;

        if (Input.GetKey("d") && speed < carSpeed)
        {
            wheel.useMotor = true;
            speed += Time.deltaTime * 60000;
            var m = wheel.motor;
            m.motorSpeed = speed;
            wheel.motor = m;
        }

        else if (Input.GetKey("a") && speed > -carSpeed)
        {
            wheel.useMotor = true;
            speed -= Time.deltaTime * 60000;
            var m = wheel.motor;
            m.motorSpeed = speed;
            wheel.motor = m;
        }

        else
        {
            wheel.useMotor = false;

            //if(speed < 0)
            //{
            //    speed += Time.deltaTime * 2000;
            //}

            //else if(speed > 0)
            //{
            //    speed -= Time.deltaTime * 2000;
            //}
            //print(wheel.useMotor);

            //var m = wheel.motor;
            //m.motorSpeed = speed;
            //wheel.motor = m;
        }
    }

    //private void RotateInAir()
    //{



    //    if (Input.GetKey("d"))
    //    {
    //        z += .1f;

    //        parentTransform.rotation = Quaternion.Euler(0, 0, z);
           
    //    }

    //    else if (Input.GetKey("a"))
    //    {
    //        z += -.1f;

    //        parentTransform.rotation = Quaternion.Euler(0, 0, z);
    //    }
    //}
}
