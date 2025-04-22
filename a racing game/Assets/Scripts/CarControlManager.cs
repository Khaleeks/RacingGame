using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class EnableCarScripts : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject DreamCar;

    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        DreamCar.GetComponent<CarAIControl>().enabled = true;
        DreamCar.GetComponent<CarController>().enabled = true;

    }
}
