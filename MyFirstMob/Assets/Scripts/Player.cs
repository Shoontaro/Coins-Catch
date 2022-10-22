using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Spine.Unity;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public Font fontUI;
    public GameObject panel;
    public GameObject canvasGO;
    public GameObject imageGO;
    public GameObject panelGameOver;
    public GameObject panelWin;
    public AudioSource soundCoin;
    public AudioSource soundBrick;
    public AudioSource soundWind;
    public AudioSource soundBag;
    public AudioSource soundGlas;
    public AudioSource soundBook;
    public AudioSource soundMachette;
    public AudioSource soundSword;
    public AudioSource soundBomb;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int i = 0;
    public static int countLvl4 = 0;
    public static int score = 0;
    public static int itemScore = 0;
    public static int scoreTarget = 0;
    public static int bookscore = 0;
    public string labelTextLevel2 = "You earned 100 coins";
    public string labelTextLevel3 = "You earned 300 coins";
    public static List<string> elem = new List<string>() { "Coin", "Target", "bottle", "rope", "book", "bandage" };


    void Awake()
    {
        lose = false;
        i = 0;
        score = 0;
        scoreTarget = 0;
        bookscore = 0;
        countLvl4 = 0;

        SkeletonAnimation.timeScaleCopy = 1;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level4" && lose == true)
        {
            panel.SetActive(lose);
            PlayerPrefs.SetInt("Score", 1000);
        }

        if (SceneManager.GetActiveScene().name == "Level3" && Timer.timeStart < 1f)
        {
            lose = true;
            panel.SetActive(lose);
            PlayerPrefs.SetInt("Score", 300);
        }
    }

    private void OnGUI()
    {
       // Color newColor = new Color(25, 112, 35, 1);
        GUIStyle myStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        myStyle.fontSize = 65;
        myStyle.normal.textColor = Color.white;
        myStyle.alignment = TextAnchor.MiddleCenter;
        myStyle.font = fontUI;

        if (SceneManager.GetActiveScene().name == "Level2" && panel.activeSelf && lose == true)
        {
            GUI.Label(new Rect(Screen.width /7, Screen.height /4, 800, 700), labelTextLevel2, myStyle);
        }

        if (SceneManager.GetActiveScene().name == "Level3" && panel.activeSelf && Timer.timeStart < 1f)
        {
            GUI.Label(new Rect(Screen.width / 7, Screen.height / 4, 800, 700), labelTextLevel3, myStyle);
        }
    }

    public void LoseSome()
    {
        i++;

        if (i >= 1) { heart1.SetActive(lose); }
        if (i >= 2) { heart2.SetActive(lose); }
        if (i >= 3)
        {
            heart3.SetActive(lose);
            lose = true;
            panel.SetActive(lose);
            FallDown.falls = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick" || other.gameObject.tag == "Machette" || other.gameObject.tag == "Sword" || other.gameObject.tag == "Bomb")
        {
            switch (other.gameObject.tag)
            {
                case "Brick":
                    soundBrick.Play();
                    break;
                case "Machette":
                    soundMachette.Play();
                    break;
                case "Sword":
                    soundSword.Play();
                    break;
                case "Bomb":
                    soundBomb.Play();
                    break;
            }

            i++;

            FallDown.falls = 0f;

            if (i >= 1) { heart1.SetActive(lose); }
            if (i >= 2) { heart2.SetActive(lose); }
            if (i >= 3)
            {
                heart3.SetActive(lose);
                lose = true;
                FallDown.falls = 0;
                panel.SetActive(lose);
            }
        }

        if (elem.IndexOf(other.gameObject.tag) != -1)
        {
            switch (other.gameObject.tag)
            {
                case "Coin":
                    score++;
                    soundCoin.Play();
                    break;
                case "Target":
                    soundWind.Play();
                    if (scoreTarget < 10)
                        scoreTarget++;
                    break;
                case "book":
                    soundBook.Play();
                    if (bookscore < 20)
                        bookscore++;
                    break;
                case "bottle":
                    soundGlas.Play();
                    break;
                case "rope":
                case "bandage":
                    soundBag.Play();
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

                    //if (score == 300)
                    //{

                    //}

                    break;

                case "Level2":

                    if (bookscore >= 20 && scoreTarget == 10) // 5 - 8
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

                    if (itemScore == 50) //50
                    {
                        lose = true;
                        panel.SetActive(lose);
                        FallDown.falls = 0;
                        PlayerPrefs.SetInt("Score", score + 1000);
                        panelGameOver.SetActive(true);
                        canvasGO.SetActive(false);
                        imageGO.SetActive(false);
}
                    else
                    {
                        if (other.gameObject.tag != "Coin")
                        {
                            itemScore++;
                        }

                        if (itemScore % 5 == 0)
                        {
                            FallDown.falls += 0.5f;
                            SkeletonAnimation.timeScaleCopy += 1;

                        }
                    }
                    break;
            }

        }
        Destroy(other.gameObject);
    }
}
