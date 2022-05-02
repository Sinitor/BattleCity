using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float speed = 12f;
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
        if (collision.gameObject.tag == "Barrier" || collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        { 
            collision.gameObject.GetComponent<EnemyHP>().TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
