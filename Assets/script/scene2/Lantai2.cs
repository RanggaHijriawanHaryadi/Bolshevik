using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Lantai2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<player2>().Lantai = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<player2>().Lantai = false;
        }
    }

}
