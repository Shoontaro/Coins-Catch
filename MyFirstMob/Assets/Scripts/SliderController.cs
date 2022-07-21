using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public float oldVolume;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (oldVolume != slider.value)
        {

        }
    }
}
