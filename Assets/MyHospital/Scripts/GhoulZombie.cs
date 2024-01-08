using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhoulZombie : MonoBehaviour
{
    public Transform Target;
    public AudioSource Sound;
    public Animator Animator;
    private NavMeshAgent Agent;
    private float RoarTimeInterval = 5.0f;
    private float RoarTimeAcc;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        RoarTimeAcc = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        RoarTimeAcc += Time.deltaTime;
        if (RoarTimeAcc >= RoarTimeInterval)
        {
            RoarTimeAcc = 0f;
            Sound.Play();
        }

        if (Agent.enabled)
        {
            Agent.destination = Target.position;
            if ((float)Vector3.Distance(Target.position, transform.position) < 3)
            {
                Animator.SetTrigger("Attack");
            }
            else
            {
                Animator.SetBool("IsWalking", true);
            }
        }
        else
        {
            Animator.SetBool("IsWalking", false);
        }

    }

    public void Freeze()
    {
        Agent.enabled = false;
    }

    public void UnFreezed()
    {
        Agent.enabled = true;
    }
}
