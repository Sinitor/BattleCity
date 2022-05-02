using UnityEngine;

public class BlockHP : MonoBehaviour
{
    public float health = 10f;
    [SerializeField] private GameObject destroyEffect;
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
        Destroy(gameObject);
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
    }
}
