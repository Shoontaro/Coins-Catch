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

    public GameObject purchasePanel;
    public GameObject button2Copy;

    //public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public int levelComplete;

    public int levels;

    private void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;

        switch (levelComplete)
        {
            case 2:
                level2.interactable = true;
                break;
            case 3:
                level2.interactable = true;
                level3.interactable = true;
                break;
            case 4:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                break;
        }

        Debug.Log(levelComplete);

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

    private void Update()
    {
        //if (Player.score >= 5)
        //{
        //    levelComplete = 2;
        //    PlayerPrefs.SetInt("LevelComplete", levelComplete);
        //}
    }

    public void SetActivePurchasePanel()
    {
        purchasePanel.SetActive(true);
    }

    public void PressBuy2()
    {
        Destroy(button2Copy);
        level2.interactable = true;
        purchasePanel.SetActive(false); ;
    }
    public void Level1Pressed()
    {
        buttonPressed.Play();
        SceneManager.LoadScene("Level1");
    }

    //public void Level2Pressed()
    //{
    //    buttonPressed.Play();
    //    SceneManager.LoadScene("Level2");
    //}

    //public void Level3Pressed()
    //{
    //    buttonPressed.Play();
    //    SceneManager.LoadScene("Level3");
    //}

    //public void Level4Pressed()
    //{
    //    buttonPressed.Play();
    //    SceneManager.LoadScene("Level4");
    //}

    //public void Level5Pressed()
    //{
    //    buttonPressed.Play();
    //    SceneManager.LoadScene("Level5");
    //}

    public void ExitPressed()
    {
        buttonPressed.Play();
        Application.Quit();
    }

    public void ButtonPressed()
    {
        buttonPressed.Play();
    }

    public void ResetSavedData()
    {
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        PlayerPrefs.DeleteAll(); // or DeleteKey()
        moneyText.text = 0.ToString();
    }

    public void LoadTo(int level)
    {
        buttonPressed.Play();
        SceneManager.LoadScene(level);
    }


}