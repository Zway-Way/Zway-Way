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
        //calls the text font
        score = GetComponent<Text>();
    }

    
    void Update()
    {
        // Adds the coins collected to the counter while updating
        //every new coin collected to new total
        score.text = "Coins: " + CoinCount + "/4";
    }
}
