using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour {

    Rigidbody rb;
    Vector3 target;
    public float speed = 100.0f;
    public float max_speed = 200.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        target = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        target += new Vector3(Input.GetAxis("Mouse X"),0, Input.GetAxis("Mouse Y"));
        rb.AddForce((target - transform.position) * speed * rb.mass);
        rb.velocity *= 0.6f;
        if (rb.velocity.magnitude > max_speed)
            rb.velocity = rb.velocity.normalized * max_speed;
	}
}
