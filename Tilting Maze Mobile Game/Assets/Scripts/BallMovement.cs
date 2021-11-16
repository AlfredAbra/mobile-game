using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;

    float ballSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // The acceleration.y variable is used within the z-axis part of the Vector3 variable so it matches the phone's tilt correctly (so if the phone is tilted forward it moves on te z-axis in the game scene).
        Vector3 ballTilt = new Vector3 (Input.acceleration.x,0f, Input.acceleration.y);

        // This adds the velocity to the ball game object and also uses the ballSpeed value as well to move at a certain speed.
        rb.velocity = ballTilt * ballSpeed;

    }
}
