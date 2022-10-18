using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Book_text : MonoBehaviour
{
    public Text MyText;

    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            MyText.text = $"X 0/50";
            MyText.color = new Color(255, 255, 255);
        }
        else
        {
            MyText.text = $"X 0/20";
            MyText.color = new Color(255, 255, 255);
        }
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            MyText.text = $"X {Player.itemScore}/50";
            if (Player.itemScore == 50)
            {
                MyText.color = new Color(0, 255, 0);
            }
        }
        else
        {
            MyText.text = $"X {Player.bookscore}/20";

            if (Player.bookscore == 20)
            {
                MyText.color = new Color(0, 255, 0);
            }
        }
    }
}