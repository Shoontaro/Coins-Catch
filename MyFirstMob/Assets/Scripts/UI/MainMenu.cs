using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonPressed;
    public void Level1Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level1");
    }

    public void Level2Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level2");
    }

    public void Level3Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level3");
    }

    public void Level4Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level4");
    }

    public void Level5Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level5");
    }

    public void ExitPressed()
    {
        buttonPressed.Play();
        Application.Quit();
    }

    public void ButtonPressed()
    {
        buttonPressed.Play();
    }

}