using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    public AudioClip backgroundMusicClip;
    public float volume = 1.0f; // Volume control (0.0 to 1.0)
    private AudioSource backgroundMusicSource;

    private void Start()
    {
        backgroundMusicSource = gameObject.AddComponent<AudioSource>();
        backgroundMusicSource.clip = backgroundMusicClip;
        backgroundMusicSource.loop = true;
        backgroundMusicSource.volume = volume; // Set the initial volume
        backgroundMusicSource.Play();
    }

    // Method to change the volume during runtime

}
