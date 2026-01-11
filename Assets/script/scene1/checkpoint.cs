using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public static Vector3 respawnPosition;
    public static int savenyawa;

    public void Start()
    {
        respawnPosition = transform.position;
        savenyawa = managerDragon.Instance.nyawa;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("checkPoint"))
        {
            respawnPosition = collision.transform.position;
            savenyawa = managerDragon.Instance.nyawa;

            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("checkpoint");
        }
    }
}
