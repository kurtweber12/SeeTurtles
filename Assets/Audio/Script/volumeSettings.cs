using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider environmentSlider;
    [SerializeField] private Slider narrationSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume") || PlayerPrefs.HasKey("environmentVolume") || PlayerPrefs.HasKey("narrationVolume"))
        {
            LoadVolume();
        } else
        {
            SetMusicVolume();
            SetEnvironmentVolume();
            SetNarrationVolume();
        }
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    public void SetEnvironmentVolume()
    {
        float volume = environmentSlider.value;
        myMixer.SetFloat("environment", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("environmentVolume", volume);
    }
    public void SetNarrationVolume()
    {
        float volume = narrationSlider.value;
        myMixer.SetFloat("narration", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("narrationVolume", volume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        environmentSlider.value = PlayerPrefs.GetFloat("environmentVolume");
        narrationSlider.value = PlayerPrefs.GetFloat("narrationVolume");
        SetMusicVolume();
        SetEnvironmentVolume();
        SetNarrationVolume();
    }
}
