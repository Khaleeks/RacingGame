using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour
{

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("carPos"))
        {
            positionDisplay.GetComponent<TextMeshProUGUI>().text = "2nd Place";
        }
    }
}
