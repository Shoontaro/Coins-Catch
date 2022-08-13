
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
<<<<<<< Updated upstream
    public GameObject restart;
    public GameObject ex;
=======
    //public static bool win = false;
    // public GameObject restart;
    // public GameObject exit;
    public GameObject panel;
    // public GameObject panelWin;
>>>>>>> Stashed changes
    public AudioSource soundCoin;
    public AudioSource soundBrick;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int i = 0;
    public static int score = 0;

<<<<<<< Updated upstream


    void Awake() {
=======
    void Awake()
    {
        //Debug.Log(SceneManager.GetActiveScene().name);
>>>>>>> Stashed changes
        lose = false;
        //win = false;
        i = 0;
        score = 0;
<<<<<<< Updated upstream
    }

    void OnTriggerEnter2D(Collider2D other) {
        
    if(other.gameObject.tag == "Brick")
=======
        scoreTarget = 0;
        Timer.timeStart = 15f;
    }


    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level3" && Timer.timeStart < 1f)
        {
            //Debug.Log("ѕобеда-победа!");
            lose = true;
            panel.SetActive(lose);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick" || other.gameObject.tag == "Machette" || other.gameObject.tag == "Sword" || other.gameObject.tag == "Bomb")
>>>>>>> Stashed changes
        {
            soundBrick.Play();
            i++;

            FallDown.falls = 0f;

            if (i>=1) { heart1.SetActive(lose); }
            if (i>=2) { heart2.SetActive(lose); }
            if (i >= 3) {
                heart3.SetActive(lose);
                lose = true;
<<<<<<< Updated upstream
                restart.SetActive(lose);
                ex.SetActive(lose);
            }
=======


                // restart.SetActive(lose);
                // exit.SetActive(lose);

                panel.SetActive(lose);
            }


>>>>>>> Stashed changes
        }

        if (other.gameObject.tag == "Coin")
        {
            
            soundCoin.Play();
            score++;

            if (score % 20 == 0) {
                FallDown.falls += 0.5f;
            }

        }

<<<<<<< Updated upstream
=======
                    break;
                case "Level2":
                    if (score >= 5 && scoreTarget == 8)
                    {
                        //Time.timeScale = 0f; //дл€ проверки работает ли
                        lose = true;
                        panel.SetActive(lose);

                    }
                    break;
                case "Level3":
>>>>>>> Stashed changes


        Destroy(other.gameObject);
    }

}
