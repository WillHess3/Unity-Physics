using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ConstantForceOnBoxes : MonoBehaviour {

    private const float FORCE_ON_BOX = 25f;

    private Rigidbody _rigidbody;

    private bool _isApplyingForce;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update() {
        _isApplyingForce = Input.GetMouseButton(0);
    }

    private void FixedUpdate() {
        if (_isApplyingForce) {
            _rigidbody.AddForce(new Vector3(FORCE_ON_BOX, 0, 0));
        }
    }

}
