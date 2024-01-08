using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UI = UnityEngine.UI;

[RequireComponent(typeof (UI.Image))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            Application.LoadLevelAsync(Application.loadedLevelName);
        }
    }
}
