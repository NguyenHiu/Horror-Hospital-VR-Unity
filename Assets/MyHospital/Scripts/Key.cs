using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyObject;
    public AudioSource PickUpSound;
    public GameObject Dialog;
    public GameObject KeyBox;

    private bool InReach = false;
    private string Text = "Pick up [E]";

    // Update is called once per frame
    void Update()
    {
        if (InReach && Input.GetButtonDown("Interact"))
        {
            keyObject.SetActive(false);
            KeyBox.SetActive(true);
            PickUpSound.Play();
            Dialog.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Reach"))
        {
            Debug.Log("Debug");
            InReach = true;
            Dialog.GetComponentInChildren<TextMeshProUGUI>().text = Text;
            Dialog.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Reach"))
        {
            InReach = false;
            Dialog.SetActive(false);
        }
    }
}
