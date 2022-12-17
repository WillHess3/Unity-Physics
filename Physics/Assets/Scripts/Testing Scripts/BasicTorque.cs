using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTorque : MonoBehaviour {

    public float torque;

    public Rigidbody rb;

    private void Start() {
        rb.centerOfMass = new Vector3(0, 0, 0);

        Debug.Log(rb.inertiaTensor.magnitude);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(1)) {
            rb.AddTorque(transform.forward * torque, ForceMode.Impulse);
        }
    }

    private void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            rb.AddTorque(transform.forward * torque);
        }
    }

}
