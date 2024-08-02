using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInstructionPopup : MonoBehaviour
{
    public TextMeshProUGUI instructionText; // For TextMeshPro
    public float displayDuration = 5f; // Duration in seconds

    void Start()
    {
        // Ensures the instruction text is visible when the scene loads
        if (instructionText != null)
        {
            instructionText.gameObject.SetActive(true);
            Invoke("HideInstruction", displayDuration); // Hides the instruction after the specified duration
        }
    }

    void HideInstruction()
    {
        if (instructionText != null)
        {
            instructionText.gameObject.SetActive(false);
        }
    }
}
