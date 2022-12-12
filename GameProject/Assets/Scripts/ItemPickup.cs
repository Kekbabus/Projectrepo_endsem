using UnityEngine;

public class ItemPickup : Interactable
{
    //we use the override we made in Interactable.cs script
    public override void Interact()
    {
        base.Interact();

        //method to pick up item
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up item");
        //remove item from scene
        Destroy(gameObject);
    }

}
