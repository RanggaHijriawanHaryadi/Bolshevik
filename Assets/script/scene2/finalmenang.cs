using UnityEngine;
using UnityEngine.SceneManagement;

public class finalmenang : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Piala"))
        {
           Destroy(gameObject);
           managerDragon.Instance.Hitungtotalskor();
           managerDragon.Instance.isMenang = true;

        }
    }
}
