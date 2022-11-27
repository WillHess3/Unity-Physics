using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    [SerializeField] private Rigidbody _rigidbody;

    private void FixedUpdate() {
        _rigidbody.AddForce(new Vector3(0, -9.81f, 0) * _rigidbody.mass);
    }

}
