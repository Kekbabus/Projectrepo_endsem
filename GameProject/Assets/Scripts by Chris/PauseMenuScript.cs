using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{ 
    public GameObject pauseMenuCanvas; // Drag the pause menu canvas to this field in the inspector

void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape)) // Check if the Escape key was pressed
    {
        if (pauseMenuCanvas.activeSelf) // If the pause menu is already active
        {
                Debug.Log("this doesnt works");
                pauseMenuCanvas.SetActive(false); // Deactivate the pause menu
            Time.timeScale = 1; // Unpause the game
        }
        else // If the pause menu is not active
        {
               Debug.Log("this works");
            pauseMenuCanvas.SetActive(true); // Activate the pause menu
            Time.timeScale = 0; // Pause the game
        }
    }
}
}