using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public GameObject player;
    public Text coinText;
    public IntData totalCoins;
    public GameObject coinObj;

    void OnTriggerEnter(Collider other)
    {
        totalCoins.value ++;
        coinText.text = totalCoins.value.ToString();
        Debug.Log("Coin Collected: " + totalCoins.value);
        gameObject.SetActive(false);
    }
}
