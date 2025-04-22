using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadLapTime : MonoBehaviour
{
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    public int MinCount;
    public int SecCount;
    public float MilliCount;

    void Start()
    {

            MinCount = PlayerPrefs.GetInt("MinSave");
            SecCount = PlayerPrefs.GetInt("SecSave");
            MilliCount = PlayerPrefs.GetFloat("MilliSave");

           
            MinDisplay.GetComponent<TextMeshProUGUI>().text = "" + MinCount + ":";
            SecDisplay.GetComponent<TextMeshProUGUI>().text = "" + SecCount + ".";
            MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + MilliCount.ToString("F1");

    }
}