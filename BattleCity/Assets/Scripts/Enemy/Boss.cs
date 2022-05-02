using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float speed = 1;
    public float distance; 

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject tower;
    private float nextTimeToFire = 0f;
    public float fireRate = 1f; 

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -distance)
        {
            speed = -speed;
        }
        if (transform.position.x > distance)
        {
            speed = 1;
        }
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1.5f / fireRate;
            Shoot();
        }
    }
    private void Shoot()
    {
        Instantiate(bulletPrefab, tower.transform.position, tower.transform.rotation);
    }
}
