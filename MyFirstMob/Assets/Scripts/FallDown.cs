using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    //[SerializeField] private Player playerScript;
    public static float falls;


    void Update()
    {
        if (transform.position.y < -5.5f || Player.lose)
        {
            Destroy(gameObject);
            if (!Player.lose && SceneManager.GetActiveScene().name == "Level4")
            {
                Player.i++;
                Debug.Log("Уронил! lox");
                //playerScript.LoseSome();
                if (Player.i == 1) { GameObject.Find("H1lvl4").SetActive(Player.lose); }
                if (Player.i == 2) { GameObject.Find("H2lvl4").SetActive(Player.lose); }
                if (Player.i == 3)
                {
                    GameObject.Find("H3lvl4").SetActive(Player.lose);
                    Player.lose = true;
                }
            }
        }

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);
    }
}
