using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Interactable close;
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
        //float horizontalInput2 = Input.GetAxis("Horizontal");
        //float forwardInput2 = Input.GetAxis("Vertical");
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
        //playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput2);
         //playerRb.AddForce(focalPoint.transform.forward * speed * horizontalInput2);

        //move player foward here
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.horizontal * Time.deltaTime * speed * horizontalInput);

        //gets player model to rotate 
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, forwardInput);

        transform.position += moveDirection * mspeed;

        //moveDirection = orientation.forward * forwardInput * orientation.right * horizontalInput;
        //rbAddForce(moveDirection.normalized * mspeed * 10f);

        //check if we are hitting an interactable
        if (forwardInput)
        {
            Interactable interactable = GetComponent<Collider>().GetComponent<Interactable>();
            if (interactable != null)
            {
                SetClose(interactable);
            }
        }

    }

    void SetClose (Interactable newClose)
    {
        if (newClose != close)
        {
            close = newClose;
        }

        //close = newClose;
        newClose.IsClose(transform);
    }

    

}
