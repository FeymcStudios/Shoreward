using UnityEngine;
using UnityEngine.AI;

public class npcKod : MonoBehaviour
{
    public Transform target; // NPC'nin takip edece�i hedef (karakter)

    private NavMeshAgent agent; // NPC'nin hareket etmek i�in kulland��� NavMeshAgent bile�eni
    private bool isAttacking = false; // NPC'nin sald�r� durumu

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

        // NPC'nin karaktere sald�rmas�
        if (target != null && Vector3.Distance(transform.position, target.position) <= agent.stoppingDistance)
        {
            if (!isAttacking)
            {
                isAttacking = true;
                playerAnimator.SetBool("isNearby", true);
                
                // Sald�r� fonksiyonunu burada �a��rabilirsiniz
                Debug.Log("NPC sald�r�yor!");
            }
        }
        else
        {
            isAttacking = false;
            playerAnimator.SetBool("isNearby", false);
        }
    }
}
