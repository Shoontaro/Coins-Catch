using System.Collections;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    public float time = 1.5f;
    //public float CoinRandom;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {

            yield return new WaitForSeconds(time);
            if (!Player.lose)
            {
                Instantiate(coin, new Vector2(Random.Range(-2f, 2f), 5.9f), Quaternion.identity);
            }
            //yield return new WaitForSeconds(Random.Range(1f, 1.8f));
        }
    }
}
