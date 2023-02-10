using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Trigger Entered!");
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("Object In Trigger");
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("Trigger Exited!");
    }

}
