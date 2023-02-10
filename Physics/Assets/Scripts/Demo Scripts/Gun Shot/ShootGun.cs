using UnityEngine;

public class ShootGun : MonoBehaviour {

    [SerializeField] private bool _isGunAiming;
    [SerializeField] private float _gunForce;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)) - transform.position;
            Ray ray = new Ray(transform.position, direction);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10f)) {
                if (hit.transform.GetComponent<Rigidbody>()) {
                    hit.transform.GetComponent<Rigidbody>().AddForceAtPosition(_gunForce * (_isGunAiming ? direction.normalized : Vector3.forward), hit.point, ForceMode.Impulse);
                }
            }
        }
    }


}
