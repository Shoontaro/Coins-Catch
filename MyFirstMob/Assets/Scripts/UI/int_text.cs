using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class int_text : MonoBehaviour
{
    public Text MyText;

    public void Start()
    {
        MyText.text = $"X 0";
    }

    public void Update()
    {
        MyText.text = $"X {Player.score}";
    }
}