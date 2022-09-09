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

    public GameObject purchasePanel2;
    public GameObject purchasePanel3;
    public GameObject purchasePanel4;

    public GameObject button2Copy;
    public GameObject button3Copy;
    public GameObject button4Copy;

    public Button buy2;
    public Button buy3;
    public Button buy4;

    public GameObject noMoney2;
    public GameObject noMoney3;
    public GameObject noMoney4;

    public Text textScore2;
    public Text textScore3;
    public Text textScore4;

    public Button level2;
    public Button level3;
    public Button level4;
    public int levelComplete;

    public int levels;

    private void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

        //level2.interactable = false;
        //level3.interactable = false;
        //level4.interactable = false; 

        switch (levelComplete)
        {
            case 0:

                level2.interactable = false;
                level3.interactable = false;
                level4.interactable = false;
                break;
            case 2:
                level2.interactable = true;
                button2Copy.SetActive(false);
                break;
            case 3:
                level2.interactable = true;
                level3.interactable = true;
                button2Copy.SetActive(false);
                button3Copy.SetActive(false);
                break;
            case 4:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                button2Copy.SetActive(false);
                button3Copy.SetActive(false);
                button4Copy.SetActive(false);

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

    public void SetActivePurchasePanel2()
    {
        purchasePanel2.SetActive(true);
        textScore2.text = $"{money}/300";

        if (money < 3) //300
        {
            buy2.interactable = false;
            noMoney2.SetActive(true);
        }
    }
    public void SetActivePurchasePanel3()
    {
        purchasePanel3.SetActive(true);
        textScore3.text = $"{money}/1000";

        if (money < 10) //1000
        {
            buy3.interactable = false;
            noMoney3.SetActive(true);
        }
    }

    public void SetActivePurchasePanel4()
    {
        purchasePanel4.SetActive(true);
        textScore4.text = $"{money}/10000";

        if (money < 11) //10000
        {
            buy4.interactable = false;
            noMoney4.SetActive(true);
        }
    }

    public void PressBuy2()
    {
        Destroy(button2Copy);
        level2.interactable = true;
        levelComplete = 2;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel2.SetActive(false); ;
    }

    public void PressBuy3()
    {
        Destroy(button3Copy);
        level3.interactable = true;
        levelComplete = 3;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel3.SetActive(false); ;
    }

    public void PressBuy4()
    {
        Destroy(button4Copy);
        level4.interactable = true;
        levelComplete = 4;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel4.SetActive(false); ;
    }

    public void MakePurchase(int needMoney)
    {
        money -= needMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyTextmoney.text = money.ToString();
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