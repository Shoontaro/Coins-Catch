using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart;
    public GameObject ex;
    public AudioSource soundCoin;
    public AudioSource soundBrick;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int i = 0;
    public static int score = 0;

    void Awake()
    {
        lose = false;
        i = 0;
        score = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Brick")
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
                restart.SetActive(lose);
                ex.SetActive(lose);
            }
        }

        if (other.gameObject.tag == "Coin")
        {
            soundCoin.Play();
            score++;

            if (score % 20 == 0)
            {
                FallDown.falls += 0.5f;
            }

        }

        Destroy(other.gameObject);
    }

}
