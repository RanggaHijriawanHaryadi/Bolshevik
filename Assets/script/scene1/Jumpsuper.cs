using UnityEngine;

public class Jumpsuper : MonoBehaviour
{
    private float jumpSuper = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSuper, ForceMode2D.Impulse);
    }

}