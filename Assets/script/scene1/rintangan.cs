using UnityEngine;

public class rintangan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("rintangan"))
        {
            managerDragon.Instance.KurangiNyawa(1);
            if(!managerDragon.Instance.isGameOver)
            {
                transform.position = checkpoint.respawnPosition;
                
            }
        }
    }
}
