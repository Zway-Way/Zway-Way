using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin") 
        {
            Destroy(collision.gameObject);
            CoinCounter.CoinCount += 1;
        }

    }
}
