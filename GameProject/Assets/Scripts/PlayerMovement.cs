using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    public float jumpHeight = 5f;
    bool isGrounded;
    float jumpTime = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        //Create an input where pressed R, restarts the current LEVEL
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        MyInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded = false;
        }
        if (!isGrounded)
        {
            jumpTime -= Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        if (!isGrounded && jumpTime > 0)
        {
            rb.AddForce(0, jumpHeight, 0);
        }
        MovePlayer();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Map")
        {
            jumpTime = 0.2f;
            isGrounded = true;
        }
    }

    private void MovePlayer()
    {
        if (isGrounded)
        {
            // Only move the player if they are on the ground
            moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
    }
}