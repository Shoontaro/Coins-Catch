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
    //public GameObject panel;


    void Update()
    {
        if (transform.position.y < -5.5f || Player.lose)
        {
            Destroy(gameObject);
            if (!Player.lose && SceneManager.GetActiveScene().name == "Level4") {

                Debug.Log("Уронил!");

                Player.i++;
               
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
            }
        }

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);

    }
}
