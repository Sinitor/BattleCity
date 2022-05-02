using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float speed = 12f;
    private void Start()
    {
        transform.eulerAngles = Vector3.forward * 180;
    }
    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block" || collision.gameObject.tag == "Base")
        {
            collision.gameObject.GetComponent<BlockHP>().TakeDamage(10);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Barrier" || collision.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHP>().TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
