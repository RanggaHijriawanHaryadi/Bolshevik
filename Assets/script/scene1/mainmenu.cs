using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    [SerializeField] GameObject PanduanMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void Pause()
    {
        PanduanMenu.SetActive(false);
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        PanduanMenu.SetActive(false);
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
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
    public void Restart()
    {
        Time.timeScale = 1f;
        if (managerDragon.Instance != null)
        {
            managerDragon.Instance.Reset();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Panduan()
    {
        PauseMenu.SetActive(false);
        PanduanMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePanduan()
    {
        PauseMenu.SetActive(true);
        PanduanMenu.SetActive(false);
        Time.timeScale = 0f;
    }
}
