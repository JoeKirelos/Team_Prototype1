using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpBullet : MonoBehaviour
{
    private Rigidbody2D bullet;
    private Vector2 upwardsMomentum = new Vector2(0f, 1f);
    private Vector2 horizontalMomentum = new Vector2(1f, 0f);
    public float speed;
    public float horSpeed;
    float rando;
    int randoSpeed;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        Invoke("RandomizeBulletDir", 0);
    }

    // Update is called once per frame
    void Update()
    {
        bullet.AddForce(upwardsMomentum *speed * Time.deltaTime);
        bullet.AddForce(horizontalMomentum * randoSpeed *horSpeed * Time.deltaTime);

    }
    void RandomizeBulletDir()
    {
        rando = Random.Range(5, 10) * 0.1f;
        horizontalMomentum *= rando;
        randoSpeed = Random.Range(2, 4);
        Invoke("RandomizeBulletDir", 1);
    }
}
