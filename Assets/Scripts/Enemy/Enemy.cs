using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target; // NPC'nin takip edeceði hedef (karakter)
    public GameObject _Player;

    private NavMeshAgent enemyAgent; // NPC'nin hareket etmek için kullandýðý NavMeshAgent bileþeni
    private bool isAttacking = false; // NPC'nin saldýrý durumu

    public Animator enemyAnimator;
    public NavMeshAgent enemy;

    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        if (enemy.velocity != Vector3.zero)
        {
            enemyAnimator.SetBool("isWalking", true);
        }
        else if (enemy.velocity == Vector3.zero)
        {
            enemyAnimator.SetBool("isWalking", false);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("AAAAAAAAAA");
        }
    }
}
