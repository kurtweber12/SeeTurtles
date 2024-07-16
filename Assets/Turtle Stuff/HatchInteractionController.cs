using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatchInteractionController : MonoBehaviour
{
    private bool playerInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Trigger the hatching process
            FindObjectOfType<TurtleHatchingController>().StartHatching();
        }
    }
}
