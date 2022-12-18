using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAround : MonoBehaviour
{

    public GameObject SphereHolder;
    public float RotationSpeed = 0.5f;
    public Vector3 axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(SphereHolder.transform.position, axis, RotationSpeed);
    }
}
