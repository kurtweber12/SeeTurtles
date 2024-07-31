using UnityEngine;

public class ISInteractionHandler : MonoBehaviour
{
    public AudioClip audioClip;
    public string interactionId; // Unique ID for this interaction
    private bool isPlayerInRange = false;

    // Reference to the marker
    public GameObject marker;

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PlayAudio();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    private void PlayAudio()
    {
        if (audioClip != null)
        {
            AudioController.Instance.PlayAudio(audioClip);
            InteractionManager.Instance.CompleteInteraction(interactionId);
            // Deactivate the marker
            if (marker != null)
            {
                marker.SetActive(false);
            }
        }
    }
}
