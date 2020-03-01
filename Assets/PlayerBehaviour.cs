using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D player;
    public int directionalMomentum;
    private Vector2 gravity = new Vector2(0f, -1f);
    public LayerMask bulletsLayer;
    public Transform parryPoint;
    public float pPointSize = 0.4f;
    Collider2D bullet;
    public Animator animator;
    public bool swingin = false ;
    public float dir;
    public float speed = 1f;
    private Vector2 horizontalMovement = new Vector2(1f, 0f);
    public int horBounce;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       dir = Input.GetAxisRaw("Horizontal");
        player.AddForce(gravity * directionalMomentum * Time.deltaTime);
       player.velocity = horizontalMovement *dir * speed*  Time.deltaTime;
        if (Input.GetKeyDown("x"))
        {
            SwingAnimation();
            swingin = true;
        }
    }
    void SwingAnimation()
    {
        animator.SetTrigger("Swipe");
    }
    private void OnDrawGizmosSelected()
    {
            Gizmos.DrawWireSphere(parryPoint.position, pPointSize);

    }
    void SwingInteraction()
    {
        if (swingin)
        {
            bullet = Physics2D.OverlapCircle(parryPoint.position, pPointSize, bulletsLayer);
            if (bullet != null)
             {
                Debug.Log("hit");
                if(directionalMomentum > 0)
                {
                    directionalMomentum = -5 * directionalMomentum;
                    int bDir = Random.Range(-2, 2);
                    player.AddForce(horizontalMovement * bDir * horBounce * Time.deltaTime);
                }
             }
        }
        }
    void NotSwingin()
    {
        swingin = false;
        if (directionalMomentum < 0)
        {
            directionalMomentum = directionalMomentum/ -5;
        }
    }
}
