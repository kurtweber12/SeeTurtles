using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource environmentSource;
    [SerializeField] AudioSource narrationSource;

    [Header("---------- Audio Clips ----------")]
    public AudioClip waves;
    public AudioClip mainMenu;
    public AudioClip underwaterAmbience;
    public AudioClip IS01B;
    public AudioClip IS02B;
    public AudioClip IS03B;
    public AudioClip IS04U;
    public AudioClip IS05U;
    public AudioClip IS06B;
    public AudioClip IS07U;
    public AudioClip IS08U;
    public AudioClip IS09B;
    public AudioClip IS10U;
    public AudioClip IS11U;

    private void Start()
    {
        musicSource.clip = mainMenu;
        musicSource.Play();
    }
}
