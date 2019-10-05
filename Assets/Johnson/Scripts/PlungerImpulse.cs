﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerImpulse : MonoBehaviour
{

    float counter;
    float counterMax = 5.0f;
    public Rigidbody body;
    bool isTouching = false;





    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Plunger"))
        {
            counter = 0;
        }
        if (Input.GetButton("Plunger"))
        {
            if (counter > counterMax)
            {
                counter = counterMax;
            }
            else
            {
                counter += .04f;
            }
            
        }
        else if (Input.GetButtonUp("Plunger"))
        {
            if (isTouching)
            {
                body.AddForce(Vector3.forward * counter, ForceMode.Impulse);
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isTouching = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isTouching = false;
    }
}
