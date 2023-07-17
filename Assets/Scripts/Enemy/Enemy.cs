using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target; // NPC'nin takip edece�i hedef (karakter)
    public GameObject _Player;

    private NavMeshAgent enemyAgent; // NPC'nin hareket etmek i�in kulland��� NavMeshAgent bile�eni
    private bool isAttacking = false; // NPC'nin sald�r� durumu

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
