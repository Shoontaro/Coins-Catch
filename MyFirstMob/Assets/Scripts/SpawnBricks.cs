using System.Collections;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public float seconds = 2.9f;
    public float start = -2f;
    public float end = 2f;
    public float ping = 2f;
   
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            Instantiate(bomb, new Vector2(Random.Range(-2f, 2f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds(2.9f);
=======
            yield return new WaitForSeconds(ping);
            if (!Player.lose) { Instantiate(bomb, new Vector2(Random.Range(start, end), 5.9f), Quaternion.identity); }
           
            //yield return new WaitForSeconds(seconds);
>>>>>>> Stashed changes
            //yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
   
}
