using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitWaiting : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Quit"))
        {
            Debug.Log("Application.Quit()");
            Application.Quit();
        }
    }
}
