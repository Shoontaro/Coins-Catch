using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int score;
    public Text moneyText;
    public AudioSource buttonPressed;
    public int money;
    public int earnedMoney;
    public Text moneyTextmoney;

    private void Start()
    {
        PlayerPrefs.GetInt("Score");
        moneyText.text = score.ToString();
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyTextmoney.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score", earnedMoney);
    }
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