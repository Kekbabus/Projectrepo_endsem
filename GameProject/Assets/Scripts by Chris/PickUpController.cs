using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PickUpController : MonoBehaviour
{
    public int counter = 0;
    // The object that should be spawned
    public GameObject prefab;

    // The position at which the object should be spawned
    public Vector3 spawnPosition = new Vector3(0, 0, 0);

    public TextMeshProUGUI counterText;
    public TextMeshProUGUI notificationTeleporter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Increase the counter by 1

            counter++;
            counterText.text = "Counter: " + counter.ToString();

            // Destroy the pickup object
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Update the counter text
        //counterText.text = "Counter: " + counter;
        
        // Check if the pickup counter has reached 25
        if (counter >= 25)
        {
            // Show the user a text that the teleporter has been spawned

                // Display the notification
                notificationTeleporter.text = "Teleporter spawned!";

            
            // Spawn the object at the specified position
            Instantiate(prefab, spawnPosition, Quaternion.identity);


        }
    }
}