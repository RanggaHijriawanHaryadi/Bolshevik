using UnityEngine;

public class Mendorong : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("box"))
        {
            Rigidbody2D boxRb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (boxRb != null)
            {
               boxRb.linearVelocity = new Vector2(rb.linearVelocity.x, boxRb.linearVelocity.y);
            }
        }
    }
}
