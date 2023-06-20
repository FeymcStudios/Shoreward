using UnityEngine;
using UnityEngine.AI;

public class npcKod : MonoBehaviour
{
    public Transform target; // NPC'nin takip edeceði hedef (karakter)

    private NavMeshAgent agent; // NPC'nin hareket etmek için kullandýðý NavMeshAgent bileþeni
    private bool isAttacking = false; // NPC'nin saldýrý durumu

    public Animator playerAnimator;
    public NavMeshAgent player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

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

        // NPC'nin karakteri takip etmesi
        if (target != null && !isAttacking)
        {
            agent.SetDestination(target.position);
        }

        // NPC'nin karaktere saldýrmasý
        if (target != null && Vector3.Distance(transform.position, target.position) <= agent.stoppingDistance)
        {
            if (!isAttacking)
            {
                isAttacking = true;
                playerAnimator.SetBool("isNearby", true);
                
                // Saldýrý fonksiyonunu burada çaðýrabilirsiniz
                Debug.Log("NPC saldýrýyor!");
            }
        }
        else
        {
            isAttacking = false;
            playerAnimator.SetBool("isNearby", false);
        }
    }
}
