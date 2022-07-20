using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    void OnMouseDown()
    {
        Application.Quit();
        //SceneManager.LoadScene("SampleScene");
    }
}


