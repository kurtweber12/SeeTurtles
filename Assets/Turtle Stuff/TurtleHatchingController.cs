using UnityEngine;

public class TurtleHatchingController : MonoBehaviour
{
    public GameObject unhatchedEggs;
    public GameObject hatchedEggs;
    public GameObject[] turtles;
    public GameObject sceneTransitionMarker; // Reference to the scene transition marker

    public void StartHatching()
    {
        // Replace unhatched eggs with hatched eggs
        unhatchedEggs.SetActive(false);
        hatchedEggs.SetActive(true);

        // Make turtles appear and start walking
        foreach (GameObject turtle in turtles)
        {
            turtle.SetActive(true);
            turtle.GetComponent<TurtleController>().StartWalking();
        }

        // Activate the scene transition marker
        if (sceneTransitionMarker != null)
        {
            sceneTransitionMarker.SetActive(true);
        }
    }
}
