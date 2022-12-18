using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // Check if the collider that entered the trigger is the player
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Get the index of the current scene
            SceneManager.LoadScene(currentSceneIndex + 1); // Load the next scene
        }
    }
}