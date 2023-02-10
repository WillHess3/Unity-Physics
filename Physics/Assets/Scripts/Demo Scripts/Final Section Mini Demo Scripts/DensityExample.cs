using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DensityExample : MonoBehaviour {

    [SerializeField] private float _targetDensity;

    private void Start() {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.SetDensity(_targetDensity);
        Debug.Log(rigidbody.mass);
    }

}
