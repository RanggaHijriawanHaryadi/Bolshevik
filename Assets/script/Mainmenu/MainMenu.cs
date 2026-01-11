using TMPro;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI bestSkorText;

    void Start()
    {
        bestSkorText.text = "" + PlayerPrefs.GetInt("BestSkor", 0).ToString();
    }
}
