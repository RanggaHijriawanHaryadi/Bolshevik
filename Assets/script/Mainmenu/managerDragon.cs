using TMPro;
using UnityEngine;

public class managerDragon : MonoBehaviour
{
    public static managerDragon Instance;
    public int skorscene1 = 0;
    public int skorscene2 = 0;
    public int totalskor;
    public int bestskor;

    public int Maxnyawa = 3;
    public int nyawa;

    public bool isMenang = false;
    public bool isGameOver = false;
    public TextMeshProUGUI baseSkor;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        if (baseSkor == null)
        {
            baseSkor = GameObject.Find("BestSkorText").GetComponent<TextMeshProUGUI>();
        }
    }

    public void Hitungtotalskor()
    {
       totalskor = skorscene1 + skorscene2;
        if (totalskor > bestskor)
        {
            bestskor = totalskor;
            saveData();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nyawa = Maxnyawa;
        loadData();
        updatebaseskor();
    }

    public void Reset()
    {
        ResetNyawa();
    }
    public void ResetNyawa()
    {
        skorscene1 = 0;
        skorscene2 = 0;
        totalskor = 0;
        nyawa = Maxnyawa;
        isGameOver = false;
    }
    public void updatebaseskor()
    {
        if (baseSkor != null)
            baseSkor.text = bestskor.ToString();
    }

    public void KurangiNyawa(int demage = 1)
    {
        if (isGameOver) return;
        nyawa -= demage;
        if (nyawa <= 0)
        {
            nyawa = 0;
            isGameOver = true;
        }
    }
    public void loadData()
    {
        bestskor = PlayerPrefs.GetInt("BestSkor", 0);
    }

    public void saveData()
    {
        PlayerPrefs.SetInt("BestSkor", bestskor);
        PlayerPrefs.Save();
    }
}
