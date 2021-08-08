using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin") 
        {
            // dissapears once collected
            Destroy(collision.gameObject);
            // updates the coin count by 1
            CoinCounter.CoinCount += 1;
        }

    }
}
