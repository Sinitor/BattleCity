using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed;
    public int rand = 1;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject tower;
    [SerializeField] private Transform sprite;
    private float nextTimeToFire = 0f;
    public float fireRate = 2f;

    private void Update()
    {
        if (rand < 10)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            speed = 2;
            sprite.transform.eulerAngles = Vector3.forward * 90;
            if (rand <= 4)
            {
                speed = -speed;
                sprite.transform.eulerAngles = Vector3.forward * -90;
            }
        }
        else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            speed = 2;
            sprite.transform.eulerAngles = Vector3.forward * 0;
            if (rand >= 13)
            {
                speed = -speed;
                sprite.transform.eulerAngles = Vector3.forward * 180;
            }
        } 

    }
    private void Shoot()
    {
        Instantiate(bulletPrefab, tower.transform.position, tower.transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Barrier")
        {
            speed = 0;
            rand = Random.Range(0, 20);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            speed = 0;
            rand = Random.Range(0, 20);
        }
        if (collision.gameObject.tag == "Player")
        {
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Barrier")
        { 
            speed = 0;
            rand = Random.Range(0, 20);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            speed = 0;
            rand = Random.Range(0, 20);
        }
        if (collision.gameObject.tag == "Player")
        {
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "Base")
        {
            if (Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
            }
        }
        if (collision.gameObject.tag == "BonusMove")
        {
            speed++;
        }
    }
}
