using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpin : MonoBehaviour {

    private Rigidbody _rigidbody;

    [SerializeField] private float _initialAngle;
    [SerializeField] private float _initialAngularVelocity;
    [SerializeField] private float _initialAngularAcceleration;

    [SerializeField] private bool _isInRadians;

    private float _time;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private float AngularKinematicEquation(float angularAcceleration, float angularVelocity, float angle) {
        return 0.5f * angularAcceleration * _time * _time + angularVelocity * _time + angle;
    }

    private void Update() {
        float angle = AngularKinematicEquation(_initialAngularAcceleration, _initialAngularVelocity, _initialAngle);
        _rigidbody.rotation = Quaternion.Euler(0, 180, _isInRadians ? Mathf.Rad2Deg * angle : angle);

        _time += Time.deltaTime;
    }

}
