using System;
using UnityEngine;

public class CatapultLaunchImpulsiveForce : MonoBehaviour {
    
    [SerializeField] private Rigidbody _rock;

    [Range(0, 90)]
    [SerializeField] private float _angle;
    [SerializeField] private float _power;

    public static event Action LaunchVisualEvent;

    private bool _isInAir;

    private void Launch() {
        _isInAir = true;
        _rock.isKinematic = false;

        LaunchVisualEvent?.Invoke();

        Vector3 forceDirection = new Vector3(Mathf.Cos(Mathf.Deg2Rad * _angle), Mathf.Sin(Mathf.Deg2Rad * _angle), 0);
        _rock.AddForce(forceDirection * _power, ForceMode.Impulse);
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && !_isInAir) {
            Launch();
        }
    }
}
