using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    // public GameObject restart;
    // public GameObject exit;
    public GameObject panel;
   // public GameObject panelWin;
    public AudioSource soundCoin;
    public AudioSource soundBrick;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int i = 0;
    public static int score = 0;
    public static int scoreTarget = 0;

    void Awake()
    {
        lose = false;
        i = 0;
        score = 0;
        scoreTarget = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick")
        {
            soundBrick.Play();
            Debug.Log("sound brick");
            i++;

            FallDown.falls = 0f;

            if (i >= 1) { heart1.SetActive(lose); }
            if (i >= 2) { heart2.SetActive(lose); }
            if (i >= 3)
            {
                heart3.SetActive(lose);
                lose = true;
                // restart.SetActive(lose);
                // exit.SetActive(lose);
                panel.SetActive(lose);
            }

            if (SceneManager.GetActiveScene().name == "Level3" && i == 3 || Timer.timeStart == 0)
            {
                Time.timeScale = 0f; //для проверки работает ли
            }
        }

        if (other.gameObject.tag == "Coin" || other.gameObject.tag == "Target")
        {
            soundCoin.Play();

            switch (other.gameObject.tag)
            {
                case "Coin":
                    score++;
                    break;
                case "Target":
                    scoreTarget++;
                    break;
            }

            switch (SceneManager.GetActiveScene().name)
            {
                case "Level1":
                    if (score % 20 == 0)
                    {
                        FallDown.falls += 0.5f;
                    }

                    break;
                case "Level2":
                    if (score >= 5 && scoreTarget == 8)
                    {
                        Time.timeScale = 0f; //для проверки работает ли
                       
                    }
                    break;
                case "Level3":

                    break;
                case "Level4":
                    break;
                case "Level5":
                    break;
            }

        }
        Destroy(other.gameObject);
    }
}
