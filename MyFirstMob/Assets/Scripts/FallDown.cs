using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 3f;
    public static float falls;

    void Update()
    {
        if (transform.position.y < -6f || Player.lose)
        {
            Destroy(gameObject);
        }

        transform.position -= new Vector3(0, (fallSpeed + falls) * Time.deltaTime, 0);

    }
}
