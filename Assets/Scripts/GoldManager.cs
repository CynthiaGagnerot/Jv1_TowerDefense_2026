using UnityEngine;
using UnityEngine.UI; 
using TMPro;


public class GoldManager : MonoBehaviour
{
    public int currentGold = 50;
    public TextMeshProUGUI goldText;

    public void AddGold(int gold)
    {
        currentGold += gold;
    }



    void Update()
    {
        goldText.text = $"Gold : {currentGold}";
    }
}
