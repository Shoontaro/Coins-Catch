using UnityEngine;
using UnityEngine.UI;

public class TextTarget : MonoBehaviour
{
    public Text MyTextTarget;

    public void Start()
    {
        MyTextTarget.text = $"X 0";
    }

    public void Update()
    {
        MyTextTarget.text = $"X {Player.scoreTarget}";
    }
}