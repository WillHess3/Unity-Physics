using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployParachute : MonoBehaviour {

    [SerializeField] private GameObject _parachute;

    private Rigidbody _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();

        _parachute.SetActive(false);
    }

    private void ParachuteDeploy() {
        _parachute.SetActive(true);

        _rigidbody.drag = 1.784f;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ParachuteDeploy();
        }
    }

}
