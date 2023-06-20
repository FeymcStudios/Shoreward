using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;



  
 public class EnemyAI : MonoBehaviour
{
    public Animator playerAnimator;
    public NavMeshAgent player;
    public Transform M_Player;
    // Use this for initialization
    

    void Update()

    {

        if (player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", false);
        }
        GetComponent<NavMeshAgent>().destination = M_Player.position;

        if (M_Player != null && Vector3.Distance(transform.position, M_Player.position) <= player.stoppingDistance)
        {
            transform.LookAt(M_Player);
            playerAnimator.SetBool("isNearby", true);
        }
        else if (M_Player != null && Vector3.Distance(transform.position, M_Player.position) > player.stoppingDistance)
        {
            playerAnimator.SetBool("isNearby", false);
        }

    }



}
