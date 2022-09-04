using UnityEngine;
using UnityEngine.UI;

public class Book_text : MonoBehaviour
{
    public Text MyText;

    public void Start()
    {
        MyText.text = $"X 0";
        MyText.color = new Color(255, 255, 255);
    }

    public void Update()
    {
        MyText.text = $"X {Player.bookscore}/5";

        if (Player.bookscore == 5)
        {
            MyText.color = new Color(0, 255, 0);
        }
    }
}