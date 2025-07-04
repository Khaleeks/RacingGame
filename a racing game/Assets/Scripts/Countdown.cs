// Jimmy Vegas Unity Tutorial with fix for music timing
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public AudioSource LevelMusic;

    void Start()
    {
        // Force-stop level music unconditionally
        LevelMusic.Stop();

        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);

        CountDown.GetComponent<TextMeshProUGUI>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        CountDown.GetComponent<TextMeshProUGUI>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        CountDown.GetComponent<TextMeshProUGUI>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);

        GoAudio.Play();
        LevelMusic.Play(); 

        LapTimer.SetActive(true);
        CarControls.SetActive(true);
    }
}