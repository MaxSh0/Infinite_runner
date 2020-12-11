using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour
{
    public GameObject Coins;
    public int CoinChance;
    // Start is called before the first frame update
    void Start()
    {
        Coins.SetActive(Random.Range(0, 101) <= CoinChance);
    }
}
