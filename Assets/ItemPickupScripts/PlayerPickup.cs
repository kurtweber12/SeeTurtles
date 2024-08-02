using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform handPosition; // A point on the player where the item will be held

    private GameObject itemInHand;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");
        if (other.gameObject.CompareTag("PickupItem"))
        {
            Debug.Log("Item entered trigger zone: " + other.gameObject.name); // Debug log for entering trigger zone
            other.gameObject.SetActive(false);
            //PickUpItem(other.gameObject);
        }
    }

    //void PickUpItem(GameObject item)
    //{
    //    if (itemInHand == null) // Check if the player is not already holding an item
    //    {
    //        Debug.Log("Picking up item: " + item.name); // Debug log for picking up item
    //        itemInHand = item;
    //        itemInHand.transform.SetParent(handPosition); // Make the item a child of the hand position
    //        itemInHand.transform.localPosition = Vector3.zero; // Position the item correctly in the hand
    //        itemInHand.GetComponent<Collider>().enabled = false; // Disable the item's collider
    //        if (itemInHand.GetComponent<Rigidbody>())
    //        {
    //            itemInHand.GetComponent<Rigidbody>().isKinematic = true; // Disable physics for the item
    //        }
    //    }
    //}


    //void Update()
    //{
    //    if (itemInHand != null && Input.GetKeyDown(KeyCode.E)) // Drop the item if 'E' is pressed
    //    {
    //        Debug.Log("Dropping item"); // Debug log for dropping item
    //        DropItem();
    //    }
    //}

    //void DropItem()
    //{
    //    Debug.Log("Item dropped"); // Debug log for item dropped
    //    itemInHand.transform.SetParent(null); // Remove the item from the player's hand
    //    itemInHand.GetComponent<Collider>().enabled = true; // Re-enable the item's collider
    //    if (itemInHand.GetComponent<Rigidbody>())
    //    {
    //        itemInHand.GetComponent<Rigidbody>().isKinematic = false; // Enable physics for the item
    //    }
    //    itemInHand = null;
    //}
}
