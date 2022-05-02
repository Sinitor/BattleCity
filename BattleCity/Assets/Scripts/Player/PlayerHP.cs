using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public float health = 10f;
    [SerializeField] private GameObject destroyEffect;
    [SerializeField] private GameObject lose;
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
        lose.gameObject.SetActive(true);
        Destroy(gameObject);
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BonusHP")
        {
            health++;
        }
    }
}
