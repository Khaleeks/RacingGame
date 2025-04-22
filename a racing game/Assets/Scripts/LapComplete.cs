//LAP COMPLETE SCRIPT

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public int laps;

    public float rawTime;
    public GameObject raceFinish;

    private void Update()
    {
        if (laps == 3)
        {
            raceFinish.SetActive(true);                                                                                                                                                                              
        }
    }

    void OnTriggerEnter()
    {
        laps += 1;
        rawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.rawTime <= rawTime)
        {

            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
            }

            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ".";
            }
            else
            {
                MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ".";
            }

            MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MilliCount;

        }
        PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
        PlayerPrefs.SetFloat("rawTime", LapTimeManager.rawTime);


        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.rawTime = 0;
        LapCounter.GetComponent<TextMeshProUGUI>().text = "" + laps;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}