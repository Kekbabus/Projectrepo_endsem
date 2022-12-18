using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Interactable close;
    public float speed = 5.0f;
    private float mspeed = 1.0f;
    //private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public Rigidbody playerRb;
    private GameObject focalPoint;


    //adding vars to make the player jump
    public float jumpAmount = 35;
    public bool isGrounded;
    float jumpTime = 2.5f;
    //public Transform orientation;

    //Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focal Point");
    }

    private void FixedUpdate()
    {
        if(!isGrounded && jumpTime >0 )
        {
            playerRb.AddForce(0, jumpAmount, 0);
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = false;   
    }
    // Update is called once per frame
    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");

        // Making player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
        }
        if (!isGrounded)
        {
            jumpTime -= Time.deltaTime;
        }


        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, forwardInput);

        transform.position += moveDirection * mspeed;



    }


    

}
