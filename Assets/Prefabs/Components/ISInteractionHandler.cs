using UnityEngine;

public class ISInteractionHandler : MonoBehaviour
{
    public AudioClip audioClip; 
    private bool isPlayerInRange = false;

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
        }
    }
}
