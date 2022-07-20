using System.Collections;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{

    public GameObject bomb;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2f, 2f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(2.9f);
            //yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
   
}
