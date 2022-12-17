using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

    [SerializeField] private GameObject _waterEffect;

    private void OnTriggerExit(Collider other) {
        if (other.transform.parent.GetComponent<Rigidbody>()) {
            Rigidbody rigidbody = other.transform.parent.GetComponent<Rigidbody>();

            rigidbody.drag = 19.62f;

            _waterEffect.SetActive(true);
        }
    }

}
