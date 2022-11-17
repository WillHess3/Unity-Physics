using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMovementTest : MonoBehaviour {

    public Rigidbody rb;

    public Vector2 initialAcceleration;
    public Vector2 initialVelocity;
    public Vector2 initialPosition;

    public float time;

    private float KinematicEquation(float acceleration, float velocity, float position) {
        return 0.5f * acceleration * time * time + velocity * time + position;
    }

    private void Update() {
        time += Time.deltaTime;

        float xPos = KinematicEquation(initialAcceleration.x, initialVelocity.x, initialPosition.x);
        float yPos = KinematicEquation(initialAcceleration.y, initialVelocity.y, initialPosition.y);
        rb.position = new Vector3(xPos, yPos, rb.position.z);
    }

}
