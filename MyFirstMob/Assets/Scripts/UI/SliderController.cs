using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float oldVolume;

    private void Start()
    {
        oldVolume = slider.value;
        if (!PlayerPrefs.HasKey("volumeValue"))
        {
            slider.value = 0.1f;
        }

        else
        {
            slider.value = PlayerPrefs.GetFloat("volumeValue");
        }
    }

    private void Update()
    {
        if (oldVolume != slider.value)
        {
            PlayerPrefs.SetFloat("volumeValue", slider.value);
            PlayerPrefs.Save();
            oldVolume = slider.value;
        }
    }
}
