using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveKey : MonoBehaviour
{
    GameObject DoorObject;

    void start()
    {
        DoorObject = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            DoorObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            DoorObject = null;
        }
    }

    public void MyActiveKey()
    {
        if (DoorObject == null)
            return;
        DoorObject.GetComponent<Door>().OpenDoor();
    }
}