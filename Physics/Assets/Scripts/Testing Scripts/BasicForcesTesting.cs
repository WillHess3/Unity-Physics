using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicForcesTesting : MonoBehaviour {

    public Rigidbody rb;

    public Vector3 force;

    private Vector3 previousVelocity = new Vector3();

    private void FixedUpdate() {
        rb.AddForce(force);
        Debug.Log("acceleration:" + ((rb.velocity - previousVelocity) / Time.fixedDeltaTime).magnitude);

        previousVelocity = rb.velocity;
    }
}
