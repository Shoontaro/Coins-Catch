using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    public static float falls;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject panel;


    void Update()
    {
        if (transform.position.y < -5.5f || Player.lose)
        {
            Destroy(gameObject);
            if (!Player.lose && SceneManager.GetActiveScene().name == "Level4") {

                Debug.Log("Уронил!");

                Player.i++;
               
                    if (Player.i >= 1) { heart1.SetActive(Player.lose); }
                    if (Player.i >= 2) { heart2.SetActive(Player.lose); }
                    if (Player.i >= 3)
                    {
                        heart3.SetActive(Player.lose);
                        Player.lose = true;
                    // restart.SetActive(lose);
                    // exit.SetActive(lose);
                       panel.SetActive(Player.lose);
                        //ex.SetActive(lose);
                    }
            }
        }

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);

    }
}
