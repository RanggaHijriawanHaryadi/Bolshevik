using UnityEngine;
using UnityEngine.SceneManagement;

public class btnpermainan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        managerDragon.Instance.Reset();
        SceneManager.LoadScene("Permainan1");
    }
    public void exit()
    {
        Application.Quit();
    }
}
