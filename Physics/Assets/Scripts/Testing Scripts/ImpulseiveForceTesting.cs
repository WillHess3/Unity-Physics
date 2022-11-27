using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseiveForceTesting : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 force;

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
