using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriggerWall : MonoBehaviour
{
    public GameObject GhouldZombie;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GhouldZombie.GetComponent<NavMeshAgent>().enabled = true;
        }
    }
}
