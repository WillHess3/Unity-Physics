using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjects : MonoBehaviour {

    [SerializeField] private List<Rigidbody> _boxes;
    [SerializeField] private float torque;

    private void Spin(bool isImpulsive) {
        foreach (Rigidbody box in _boxes) {
            ForceMode forceMode = isImpulsive ? ForceMode.Impulse : ForceMode.Force;

            box.AddTorque(Vector3.forward * torque, forceMode);
        }
    }

    private void Update() {
        if (Input.GetMouseButtonDown(1)) {
            Spin(true);
        }
    }

    private void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            Spin(false);
        }
    }

}
