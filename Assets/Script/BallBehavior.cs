using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {

    Rigidbody rb;
    public float max_speed = 200.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude > max_speed)
            rb.velocity = rb.velocity.normalized * max_speed;
    }
}
