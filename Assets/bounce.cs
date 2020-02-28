using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    private Rigidbody2D player;
    public int gForce;
    private Vector2 gravity = new Vector2(0f, -1f);
    public LayerMask bulletsLayer;
    public Transform[] parryPoints;
    public float pPointSize = 0.4f;
    Collider2D bullet;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.AddForce(gravity * gForce);
        Swing();
    }
    void Swing()
    {
            for(int i =0; i< parryPoints.Length; i++)
            {
                bullet = Physics2D.OverlapCircle(parryPoints[i].position, pPointSize, bulletsLayer);
         
            }
        if (bullet != null)
        {
            Debug.Log(bullet);
        }
    }
    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < parryPoints.Length; i++)
        {
            Gizmos.DrawWireSphere(parryPoints[i].position, pPointSize);
        }

    }
}
