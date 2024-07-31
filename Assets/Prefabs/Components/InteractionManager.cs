using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager Instance { get; private set; }

    private HashSet<string> completedInteractions = new HashSet<string>();

    public GameObject hatchingMarker; // Reference to the hatching marker
    public GameObject hatchingCollider; // Reference to the hatching collider
    public int totalAudioInteractions; // Total number of audio interactions

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CompleteInteraction(string interactionId)
    {
        completedInteractions.Add(interactionId);

        if (completedInteractions.Count >= totalAudioInteractions)
        {
            ActivateHatchingInteraction();
        }
    }

    private void ActivateHatchingInteraction()
    {
        if (hatchingMarker != null)
        {
            hatchingMarker.SetActive(true);
        }

        if (hatchingCollider != null)
        {
            hatchingCollider.SetActive(true);
        }
    }
}
