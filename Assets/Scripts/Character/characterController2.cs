using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class characterController2 : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    static bool isAttacking = false;
    public GameObject targetDest;

    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject pplayer;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if (Physics.Raycast(ray, out hitPoint))
            {
                targetDest.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);

            }


        }

        if (player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("isWalking", false);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("DestroyEnemy", 5f);
            Debug.Log("Öl");
        }

        if (collision.gameObject.tag == "Enemy1")
        {
            Invoke("DestroyEnemy1", 6f);
            Debug.Log("Öl1");
        }

        if (collision.gameObject.tag == "Enemy2")
        {
            Invoke("DestroyEnemy2", 7f);
            Debug.Log("Öl2");
        }

        if (collision.gameObject.tag == "Enemy3")
        {
            Invoke("DestroyEnemy3", 8f);
            Destroy(pplayer.gameObject);
            Debug.Log("Öl3");
        }
    }

    void DestroyEnemy()
    {
        Destroy(enemy.gameObject);

    }
    void DestroyEnemy1()
    {
        Destroy(enemy1.gameObject);

    }
    void DestroyEnemy2()
    {
        Destroy(enemy2.gameObject);
    }
    void DestroyEnemy3()
    {
        Destroy(enemy3.gameObject);

        SceneManager.LoadScene(2);
    }


}
