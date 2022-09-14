using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeStart = 45f;
    public Text timerText;

    void Start()
    {
        timerText.text = timeStart.ToString();
        timeStart = 45f;
    }

    void Update()
    {
        if (timeStart > 0 && !Player.lose)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();

        }
    }
}
