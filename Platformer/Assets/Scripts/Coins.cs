using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public GameObject player;
    public IntData totalCoins;
    public GameObject coinObj;

    void OnTriggerEnter(Collider other)
    {
        totalCoins.value ++;
        Debug.Log("Coin Collected: " + totalCoins.value);
        gameObject.SetActive(false);
    }
}
