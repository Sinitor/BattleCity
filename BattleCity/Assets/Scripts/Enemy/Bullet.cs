using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12f;
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
