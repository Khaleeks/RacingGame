using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject halfLapTrig;


    void OnTriggerEnter()
    {
        LapCompleteTrig.SetActive(true);
        halfLapTrig.SetActive(false);

    }

}
