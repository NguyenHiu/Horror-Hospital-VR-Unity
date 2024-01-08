using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    public AudioSource turnOn, turnOff;

    public void TurnOnFlashLight()
    {
        flashlight.SetActive(true);
        turnOn.Play();
    }

    public void TurnOffFlashLight()
    {
        turnOff.Play();
        flashlight.SetActive(false);
    }
}
