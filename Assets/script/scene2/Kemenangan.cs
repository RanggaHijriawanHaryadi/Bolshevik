using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kemenangan : MonoBehaviour
{
    public GameObject tampilanmenang;
    public TextMeshProUGUI skordiperoleh;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tampilanmenang.SetActive(false);
        
    }
    private void Update()
    {
        if (managerDragon.Instance.isMenang)
        {
            tampilanmenang.SetActive(true);
            Time.timeScale = 0f;
            skordiperoleh.text = managerDragon.Instance.totalskor.ToString();
        }
    }

    public void restart()
    {
        Time.timeScale = 1f;
        if (managerDragon.Instance != null)
        {
            managerDragon.Instance.Reset();
        }
        SceneManager.LoadScene("Permainan1");
    }
    public void mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainmenu");
    }
}
