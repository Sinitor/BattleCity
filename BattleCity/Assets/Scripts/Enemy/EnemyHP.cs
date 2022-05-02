using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float health = 10f;
    [SerializeField] GameObject destroyEffect;
    [SerializeField] GameObject bonus;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    private void Die()
    {
        Score.score++;
        Destroy(gameObject);
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Instantiate(bonus, transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BonusHP")
        {
            health++;
        }
    }
}
