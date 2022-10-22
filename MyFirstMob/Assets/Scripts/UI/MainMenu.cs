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
    public GameObject optionsPanel;

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

    public Button level1;
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
    }

    public void SetActivePurchasePanel2()
    {
        Debug.Log(levelComplete);

        ButtonPressed();
        purchasePanel2.SetActive(true);
        textScore2.text = $"{money}/300";

        if (money < 300) //300
        {
            buy2.interactable = false;
            noMoney2.SetActive(true);
        }
    }
    public void SetActivePurchasePanel3()
    {
        ButtonPressed();
        purchasePanel3.SetActive(true);
        textScore3.text = $"{money}/1000";

        if (money < 1000 || levelComplete < 2) //1000
        {
            buy3.interactable = false;
            noMoney3.SetActive(true);
        }
    }

    public void SetActivePurchasePanel4()
    {
        ButtonPressed();
        purchasePanel4.SetActive(true);
        textScore4.text = $"{money}/10000";

        if (money < 10000 || levelComplete < 3) //10000
        {
            buy4.interactable = false;
            noMoney4.SetActive(true);
        }
    }

    public void PressBuy2()
    {
        ButtonPressed();
        Destroy(button2Copy);
        level2.interactable = true;
        levelComplete = 2;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel2.SetActive(false); ;
    }

    public void PressBuy3()
    {
        ButtonPressed();
        Destroy(button3Copy);
        level3.interactable = true;
        levelComplete = 3;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel3.SetActive(false); ;
    }

    public void PressBuy4()
    {
        ButtonPressed();
        Destroy(button4Copy);
        level4.interactable = true;
        levelComplete = 4;
        PlayerPrefs.SetInt("LevelComplete", levelComplete);
        purchasePanel4.SetActive(false); ;
    }

    public void MakePurchase(int needMoney)
    {
        ButtonPressed();
        money -= needMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyTextmoney.text = money.ToString();
    }

    public void Level1Pressed()
    {
        ButtonPressed();
        SceneManager.LoadScene("Level1");
    }

    public void ExitPressed()
    {
        ButtonPressed();
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
        ButtonPressed();
        SceneManager.LoadScene(level);
    }

    public void IsActiveOptionsPanel()
    {
        level1.interactable = false;
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
    }

    public void NotActiveOptionsPanel()
    {
        level1.interactable = true;
        level2.interactable = true;
        level3.interactable = true;
        level4.interactable = true;
    }
}