using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource _audio;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("volumeValue"))
        {
            _audio.volume = 0.1f;
        }
    }
    private void Update()
    {
        _audio.volume = PlayerPrefs.GetFloat("volumeValue");

    }
}
