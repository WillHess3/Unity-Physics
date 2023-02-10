using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionExample : MonoBehaviour {

    private Rigidbody _rigidbody;

    [SerializeField] private float _explosionForce;
    [SerializeField] private Transform _bombTransform;
    [SerializeField] private float _radius;
    [SerializeField] private float _upwardsModifier;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Explode();
        }
    }

    private void Explode() {
        _rigidbody.AddExplosionForce(_explosionForce, _bombTransform.position, _radius, _upwardsModifier, ForceMode.Impulse);
    }
}
