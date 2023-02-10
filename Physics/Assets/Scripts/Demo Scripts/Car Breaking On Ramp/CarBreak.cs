using UnityEngine;

public class CarBreak : MonoBehaviour {

    [SerializeField] private Rigidbody _rigidbody;

    [Min(0)]
    [SerializeField] private float _breakForceMagnitude;

    [SerializeField] private bool _isUsingEquilibriumForceWhenBreaking;

    private bool _isBreaking;

    private Vector3 _stopPosition;
    
    private bool IsCarStopped() {
        if (_rigidbody.velocity.x <= 0.01f && _isBreaking) {
            _rigidbody.velocity = Vector3.zero;

            return true;
        } else {
            return false;
        }
    }

    private float GetEquilibriumForceMagnitude(float angle) {
        return _rigidbody.mass * -1 * Physics.gravity.y * Mathf.Sin(-1 * angle);
    }

    private void Break(float breakForceMagnitude) {
        /*I'm using transform.right and not transform.forward because the 
          orientation got messed up when importing from blender again (facepalm)*/

        _rigidbody.AddForce(-1 * breakForceMagnitude * transform.right);
    }

    private void Update() {
        _isBreaking = Input.GetMouseButton(0);

        if (!_isUsingEquilibriumForceWhenBreaking) {
            if (IsCarStopped()) {
                _stopPosition = _rigidbody.position;
                _rigidbody.useGravity = false;
            } else {
                _rigidbody.useGravity = true;
            }
        }
    }

    private void FixedUpdate() {
        if (_isBreaking && !IsCarStopped()) {
            Break(_breakForceMagnitude);
        } else if (_isBreaking && IsCarStopped()) {
            if (_isUsingEquilibriumForceWhenBreaking) {
                Break(GetEquilibriumForceMagnitude(Mathf.Deg2Rad * transform.rotation.x));
            } else {
                _rigidbody.position = _stopPosition;
            }
        }
    }

}
