using UnityEngine;

public class HatchInteractionController : MonoBehaviour
{
    private bool playerInRange;

    public GameObject hatchingMarker; // Reference to the hatching marker

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
            // Deactivate the hatching marker
            if (hatchingMarker != null)
            {
                hatchingMarker.SetActive(false);
            }
        }
    }
}
