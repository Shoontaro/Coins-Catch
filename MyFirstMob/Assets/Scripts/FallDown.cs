
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    public static float falls;

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (transform.position.y <-6f) { Destroy(gameObject); }
=======
        if (transform.position.y < -6f || Player.lose)
        {
            Destroy(gameObject);
        }
>>>>>>> Stashed changes

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);
        
    }
}
