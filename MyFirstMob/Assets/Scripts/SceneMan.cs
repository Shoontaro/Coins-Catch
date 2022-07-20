using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
   public void NextLevel(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
}
