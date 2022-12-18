using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // The distance that the object should move up and down on the Y axis
    public float movementDistance = 0.3f;

    // The speed at which the object should move
    public float movementSpeed = 1f;

    // The range of time over which the object should complete one full movement cycle
    public float movementTime = 1f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the current time as a value between 0 and 1
        float t = Time.time / movementTime;

        // Use Mathf.PingPong to oscillate the object's position between 0 and the movement distance
        float y = Mathf.PingPong(t * movementSpeed, movementDistance);

        // Update the object's position on the Y axis
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}