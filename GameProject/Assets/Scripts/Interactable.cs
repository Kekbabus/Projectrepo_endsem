using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 2f;

    bool close = false;
    Transform player;

    bool hasInteracted = false;

    //so we are able to call it and overwrite in other scripts
    public virtual void Interact ()
    {
        Debug.Log("Picked up" + transform.name);
    }

    void Update()
    {
        if (close && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    //to check if player is close enough to pick up item
    public void IsClose (Transform playerTransform)
    {
        close = true;
        player = playerTransform;
        hasInteracted = false;
    }

    //to know when player is not close enough to pick up item
    public void NotClose()
    {
        close = false;
        player = null;
        hasInteracted = false;
    }

    //this allows us see the field area on how close the player can get
    void OnDrawGizmosSelected()
    {   //set color of outline
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
