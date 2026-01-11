using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nyawabar2 : MonoBehaviour
{

    [SerializeField] private Image[] nyawaimage;
    [SerializeField] GameObject GameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameOver.SetActive(false);
    }
    void Update()
    {
        UpdateNyawa();
        CekGameOver();
    }

    void UpdateNyawa()
    {
        int nyawa = managerDragon.Instance.nyawa;

        for (int i = 0; i < nyawaimage.Length; i++)
        {
            if (i < nyawa)
            {
                nyawaimage[i].enabled = true;
            }
            else
            {
                nyawaimage[i].enabled = false;
            }
        }
    }

    public void CekGameOver()
    {
        if (managerDragon.Instance.isGameOver)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        if (managerDragon.Instance != null)
        {
            managerDragon.Instance.Reset();
        }
        SceneManager.LoadScene("Permainan1");
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        if (managerDragon.Instance != null)
        {
            managerDragon.Instance.Reset();
        }
        SceneManager.LoadScene("MainMenu");
    }
}
