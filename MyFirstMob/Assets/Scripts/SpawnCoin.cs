using System.Collections;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    //public float CoinRandom;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
<<<<<<< Updated upstream
            
            Instantiate(coin, new Vector2(Random.Range(-2f, 2f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
=======
            yield return new WaitForSeconds(time);
            if (!Player.lose)
            {
                Instantiate(coin, new Vector2(Random.Range(-2f, 2f), 5.9f), Quaternion.identity);
            }
            
>>>>>>> Stashed changes
            //yield return new WaitForSeconds(Random.Range(1f, 1.8f));
        }
    }
}
