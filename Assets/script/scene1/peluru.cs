using UnityEngine;

public class peluru : MonoBehaviour
{
    public float speedPeluru = 5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.left * speedPeluru;
    }

    // Update is called once per frame
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            managerDragon.Instance.KurangiNyawa(1);
            if (!managerDragon.Instance.isGameOver)
            {
                collision.transform.position = checkpoint.respawnPosition;

            }
            Destroy(gameObject);
            return;
        }
        if (collision.gameObject.CompareTag("box")||(collision.gameObject.CompareTag("Dinding")))
        {
            Destroy(gameObject);
        }
    }

}
