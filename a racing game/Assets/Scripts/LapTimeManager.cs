using UnityEngine;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public static float rawTime;

    void Update()
    {
        // Add the time passed to MilliCount
        MilliCount += Time.deltaTime * 10;
        rawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<TextMeshProUGUI>().text = MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }


        // If the seconds are less than 10, display a leading zero
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<TextMeshProUGUI>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<TextMeshProUGUI>().text = "" + SecondCount + ".";
        }

        // If seconds reach 60, reset and increment minutes
        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        // Display the minute count
        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<TextMeshProUGUI>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<TextMeshProUGUI>().text = "" + MinuteCount + ":";
        }
    }
}
