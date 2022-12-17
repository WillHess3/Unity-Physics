using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour {

    [SerializeField] private Rigidbody _rigidbody;

    private const float THRUST_FORCE_MAGNITUDE = 300000;

    private void FixedUpdate() {
        /*I'm using vector3.forward and not transform.forward because 
          the orientation got messed up when importing from blender */

        _rigidbody.AddForce(Vector3.forward * THRUST_FORCE_MAGNITUDE);
    }

}
