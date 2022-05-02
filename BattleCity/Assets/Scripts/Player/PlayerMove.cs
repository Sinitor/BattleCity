using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    private Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = Vector3.forward * 180;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = Vector3.forward * 90;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.forward * -90;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BonusMove")
        {
            speed++;
        }
    }
} 


