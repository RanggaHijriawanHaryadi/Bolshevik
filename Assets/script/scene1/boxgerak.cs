using UnityEngine;

public class box : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach(ContactPoint2D contact in collision.contacts)
            {
                if(contact.normal.y < -0.5f)
                {
                    collision.gameObject.GetComponent<player>()
                    .onBox(true);
                }
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           collision.gameObject.GetComponent<player>().onBox(false);
        }
    }
}

