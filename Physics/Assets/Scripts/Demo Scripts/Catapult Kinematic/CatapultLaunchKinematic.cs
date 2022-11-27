using System;
using System.Collections.Generic;
using UnityEngine;

public class CatapultLaunchKinematic : MonoBehaviour {

    [SerializeField] private Rigidbody _rock;

    [Range(0, 90)]
    [SerializeField] private float _angle;
    [SerializeField] private float _power;

    private Vector2 _initialVelocity;
    private Vector2 _initialPosition;
    private float _time;
    private bool _isInAir;

    public static event Action LaunchVisualEvent;

    private void Launch() {
        LaunchVisualEvent?.Invoke();

        _initialVelocity = new Vector2(Mathf.Cos(_angle * Mathf.PI / 180), Mathf.Sin(_angle * Mathf.PI / 180)) * _power;
        _initialPosition = new Vector2(_rock.position.x, _rock.position.y);

        _isInAir = true;
    }

    private float KinematicEquation(float acceleration, float velocity, float position) {
        return 0.5f * acceleration * _time * _time + velocity * _time + position;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Launch();
        }

        if (_isInAir) {
            _time += Time.deltaTime;

            float newRockX = KinematicEquation(0, _initialVelocity.x, _initialPosition.x);
            float newRockY = KinematicEquation(-9.81f, _initialVelocity.y, _initialPosition.y);

            _rock.position = new Vector3(newRockX, newRockY, _rock.position.z);
        }
    }
}
