using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMassExample : MonoBehaviour {

    [SerializeField] private Vector3 _centerOfMass;

    private void Start() {
        GetComponent<Rigidbody>().centerOfMass = _centerOfMass;
    }

}
