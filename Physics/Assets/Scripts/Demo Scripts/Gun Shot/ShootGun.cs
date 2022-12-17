using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour {

    [SerializeField] private bool _isGunAiming;
    [SerializeField] private float _gunForce;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log(1);
            Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position;
            Ray ray = new Ray(transform.position, direction);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10f)) {
                Debug.Log(2);
                if (hit.transform.GetComponent<Rigidbody>()) {
                    Debug.Log(3);
                    hit.transform.GetComponent<Rigidbody>().AddForceAtPosition(_gunForce * (_isGunAiming ? direction.normalized : Vector3.forward), hit.point, ForceMode.Impulse);
                }
            }
        }
    }


}
