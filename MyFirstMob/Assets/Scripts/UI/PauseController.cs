using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseController : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}



//private void Start()
//{
//    oldVolume = slider.value;
//    if (!PlayerPrefs.HasKey("volumeValue"))
//    {
//        slider.value = 0.1f;
//    }

//    else
//    {
//        slider.value = PlayerPrefs.GetFloat("volumeValue");
//    }
//}

//private void Update()
//{
//    if (oldVolume != slider.value)
//    {
//        PlayerPrefs.SetFloat("volumeValue", slider.value);
//        PlayerPrefs.Save();
//        oldVolume = slider.value;
//    }
//}