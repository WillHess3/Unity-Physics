using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocityTesting : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 initialVelocity;

    private void Start() {
        rb.velocity = initialVelocity;
    }
}
