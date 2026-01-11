using UnityEngine;
using UnityEngine.InputSystem;

public class Koinskor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private AudioSource pemutarsuara;
    // Update is called once per frame
    void Start()
    {
        pemutarsuara = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<player>().TambahSkor(10);
            pemutarsuara.Play();
            GetComponent<Collider2D>().enabled = false;
            
            Destroy(gameObject, pemutarsuara.clip.length);
        }
    }
}

