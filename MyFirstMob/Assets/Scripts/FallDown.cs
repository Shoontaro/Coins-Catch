
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    public static float falls;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <-6f) { Destroy(gameObject); }

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);
        
    }
}
