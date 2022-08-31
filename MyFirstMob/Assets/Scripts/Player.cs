using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    // public GameObject restart;
    // public GameObject exit;
    public GameObject panel;
    public GameObject panelWin;
    public AudioSource soundCoin;
    public AudioSource soundBrick;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int i = 0;
    public static int countLvl4 = 0;
    public static int score = 0;
    public static int scoreTarget = 0;
    public static int bookscore = 0;
    public string labelTextLevel2 = "You earned 100 coins";
    public string labelTextLevel3 = "You earned 300 coins";
    public static List<string> elem = new List<string>() { "Coin", "Target", "bottle", "rope", "book", "bandage" };

    void Awake()
    {
        //List<string>  elem = new List<string>() { "Coin", "Target", "bottle", "rope", "book", "bandage" };
        //Debug.Log(elem[0]);

        lose = false;
        i = 0;
        score = 0;
        scoreTarget = 0;
        bookscore = 0;
        countLvl4 = 0;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level3" && Timer.timeStart < 1f)
        {
            lose = true;
            //panelWin.SetActive(lose);
            panel.SetActive(lose);
            PlayerPrefs.SetInt("Score", 300);
        }


    }

    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        myStyle.fontSize = 110;
        myStyle.normal.textColor = Color.red;
        myStyle.alignment = TextAnchor.MiddleCenter;

        if (SceneManager.GetActiveScene().name == "Level2" && panel.activeSelf && lose == true)
        {
            GUI.Label(new Rect(Screen.width / 4, Screen.height / 3, 600, 600), labelTextLevel2, myStyle);
        }

        if (SceneManager.GetActiveScene().name == "Level3" && panel.activeSelf && Timer.timeStart < 1f)
        {
            GUI.Label(new Rect(Screen.width / 4, Screen.height / 3, 600, 600), labelTextLevel3, myStyle);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick" || other.gameObject.tag == "Machette" || other.gameObject.tag == "Sword" || other.gameObject.tag == "Bomb")
        {
            soundBrick.Play();
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
                //ex.SetActive(lose);
            }

            /* if (SceneManager.GetActiveScene().name == "Level3" && i == 3 || Timer.timeStart == 0)
             {
                 Time.timeScale = 0f; //для проверки работает ли
             }*/
        }

        if (elem.IndexOf(other.gameObject.tag) != -1 /*other.gameObject.tag == "Coin" || other.gameObject.tag == "Target"||other.gameObject.tag == "bottle"|| other.gameObject.tag == "rope" || other.gameObject.tag == "book" || other.gameObject.tag == "bandage"*/)
        {
            soundCoin.Play();

            switch (other.gameObject.tag)
            {
                case "Coin":
                    score++;
                    break;
                case "Target":
                    if (scoreTarget < 8)
                        scoreTarget++;
                    break;
                case "book":
                    if (bookscore < 5)
                        bookscore++;
                    break;
            }

            switch (SceneManager.GetActiveScene().name)
            {
                case "Level1":
                    PlayerPrefs.SetInt("Score", score);

                    if (score % 20 == 0)
                    {
                        FallDown.falls += 0.5f;
                    }

                    if (score == 300)
                    {
                        
                    }
                    break;
                case "Level2":

                    if (bookscore >= 5 && scoreTarget == 8)
                    {
                        // Time.timeScale = 0f; 
                        lose = true;
                        panel.SetActive(lose);
                        //panelWin.SetActive(lose);
                        PlayerPrefs.SetInt("Score", 100);
                    }
                    break;
                case "Level3":

                    break;
                case "Level4":

                    break;

            }

        }
        Destroy(other.gameObject);
    }
}
