
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOffRightWall : MonoBehaviour
{
    private Vector2 direction = new Vector2(1f, 0f);
    public float momentum = 100f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerBehaviour>().player.AddForce(direction * -momentum * Time.deltaTime);
        }
    }
}
