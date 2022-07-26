using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Level1Pressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2Pressed()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3Pressed()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Level4Pressed()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Level5Pressed()
    {
        SceneManager.LoadScene("Level5");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

}