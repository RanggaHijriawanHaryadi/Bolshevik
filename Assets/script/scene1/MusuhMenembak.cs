using System.Collections;
using UnityEngine;

public class MusuhMenembak : MonoBehaviour
{
    public GameObject peluru;
    public float jedapeluru = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame

    void Start()
    {
        StartCoroutine("TembakPeluru");
    }

    IEnumerator TembakPeluru()
    {
        while (true)
        {
            yield return new WaitForSeconds(jedapeluru);
            Vector3 posisitembak = transform.position + new Vector3(-0.5f, 0.3f, 0f);
            Instantiate(peluru, posisitembak, Quaternion.identity);
        }
    }
    
}
