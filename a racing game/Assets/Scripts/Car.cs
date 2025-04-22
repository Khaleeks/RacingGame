using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float maxSteeringAngle = 30f;
    public float baseMotorTorque = 150f; // base speed
    public float boostedMotorTorque = 300f; // boosted speed
    public float currentMotorTorque;
    public float maxBrakeTorque = 300f;

    public WheelCollider leftWheel;
    public WheelCollider rightWheel;

    public GameObject visualLeftWheel;
    public GameObject visualRightWheel;

    private bool isBoosted = false;

    void Start()
    {
        // Start at base torque
        currentMotorTorque = baseMotorTorque;
    }

    public void BoostSpeed(float duration = 3f)
    {
        if (!isBoosted)
        {
            StartCoroutine(SpeedBoost(duration));
        }
    }

    private IEnumerator SpeedBoost(float duration)
    {
        isBoosted = true;
        currentMotorTorque = boostedMotorTorque;
        yield return new WaitForSeconds(duration);
        currentMotorTorque = baseMotorTorque;
        isBoosted = false;
    }

    public void FixedUpdate()
    {
        float motor = currentMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        float brake = maxBrakeTorque * Input.GetAxis("Jump");

        leftWheel.steerAngle = steering;
        leftWheel.motorTorque = motor;
        leftWheel.brakeTorque = brake;

        rightWheel.steerAngle = steering;
        rightWheel.motorTorque = motor;
        rightWheel.brakeTorque = brake;

        Vector3 position;
        Quaternion rotation;

        leftWheel.GetWorldPose(out position, out rotation);
        visualLeftWheel.transform.position = position;
        visualLeftWheel.transform.rotation = rotation;

        rightWheel.GetWorldPose(out position, out rotation);
        visualRightWheel.transform.position = position;
        visualRightWheel.transform.rotation = rotation;
    }
}
