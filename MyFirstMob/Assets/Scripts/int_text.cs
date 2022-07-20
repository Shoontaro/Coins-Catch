using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class int_text : MonoBehaviour
{
    public Text MyText;

    // Start is called before the first frame update
    void Start()
    {
        MyText.text = $"X 0";
    }

    void Update() {
        MyText.text = $"X {Player.score}";
    }
}