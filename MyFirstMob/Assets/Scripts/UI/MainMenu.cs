using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
