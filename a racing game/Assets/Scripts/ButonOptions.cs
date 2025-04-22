using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonOptions : MonoBehaviour
{
   

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    //below here are track selection buttons
    public void Khal()
    {
        SceneManager.LoadScene(2);
    }

    public void Khal1()
    {
        SceneManager.LoadScene(3);
    }
    public void Khal2()
    {
        SceneManager.LoadScene(4);
    }
}
