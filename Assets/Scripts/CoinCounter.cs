using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static int CoinCount = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    
    void Update()
    {
        score.text = "Coins: " + CoinCount;
    }
}
