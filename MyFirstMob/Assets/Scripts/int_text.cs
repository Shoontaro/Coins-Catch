using UnityEngine;
using UnityEngine.UI;

public class int_text : MonoBehaviour
{
    public Text MyText;

    void Start()
    {
        MyText.text = $"X 0";
    }

    void Update()
    {
        MyText.text = $"X {Player.score}";
    }
}