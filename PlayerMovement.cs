﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    // Unity Inspector values.
    public float forwardForce = 2000f;
    public float backwardForce = 400f;
    public float sidewaysForce = 500F;

	// Initialization.
	void Start ()
    {
     
	}
	
	// Update called once per frame, Fixed because of physics.
	void FixedUpdate ()
    {
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);  

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime);

        }

    }
}
