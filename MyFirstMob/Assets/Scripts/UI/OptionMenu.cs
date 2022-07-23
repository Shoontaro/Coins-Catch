using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void VolumePause()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}