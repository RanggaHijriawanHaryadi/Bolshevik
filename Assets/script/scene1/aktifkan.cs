using UnityEngine;

public class aktifkan : MonoBehaviour
{
    public GameObject Tekan;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")||collision.gameObject.CompareTag("box"))
        {
            Tekan.SetActive(true);
        }
            
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("box"))
        {
            Tekan.SetActive(false);
        }
        
    }
}
