using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator OpenDoorAnimation;
    public AudioSource OpenDoorAudio;

    private bool IsOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (IsOpen)
            return;
    }

    public void OpenDoor()
    {
        OpenDoorAnimation.SetBool("Open", true);
        OpenDoorAudio.Play();
        IsOpen = true;
    }
}
