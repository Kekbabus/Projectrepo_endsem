using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CamMoveMouse : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    void Update()
    {
        //gets access to mouse up and down movements
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
