using System.Collections;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{
    public float seconds = 2.9f;
    public float start = -2f;
    public float end = 2f;

    public GameObject bomb;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(start, end), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(seconds);
            //yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
}
