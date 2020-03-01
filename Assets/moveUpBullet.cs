using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpBullet : MonoBehaviour
{
    private Rigidbody2D bullet;
    private Vector2 upwardsMomentum = new Vector2(0f, 1f);
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = upwardsMomentum * speed* Time.deltaTime;

    }
}
