using UnityEngine;
using UnityEngine.UI;

public class TextTarget : MonoBehaviour
{
    public Text MyTextTarget;

    public void Start()
    {
        MyTextTarget.text = $"X 0";
        MyTextTarget.color = new Color(255, 255, 255);
    }

    public void Update()
    {
        MyTextTarget.text = $"X {Player.scoreTarget}/10";

        if (Player.scoreTarget == 10)
        {
            MyTextTarget.color = new Color(0, 255, 0);
        }
    }
}