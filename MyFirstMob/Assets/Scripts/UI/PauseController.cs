using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseController : MonoBehaviour
{
    public AudioSource butttonPressed;
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;

        if (Player.lose)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void ButtonPressed()
    {
        butttonPressed.Play();

    }
}
