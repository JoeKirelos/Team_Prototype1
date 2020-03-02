using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float randomizer = 0.1f;
    public AudioClip shootingSound;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", 0);
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = shootingSound;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Shoot()
    {
        float shootInterval = Random.Range(1, 2);
        shootInterval += randomizer;
        Invoke("Shoot", shootInterval);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        GetComponent<AudioSource>().PlayOneShot(shootingSound);
    }
}
