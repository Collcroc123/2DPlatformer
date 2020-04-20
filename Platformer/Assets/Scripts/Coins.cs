using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public GameObject player;
    public IntData totalCoins;
    public GameObject coinObj;
    public AudioSource coinSound;

    void OnTriggerEnter(Collider other)
    {
        coinSound.Play(0);
        totalCoins.value ++;
        Debug.Log("Coin Collected: " + totalCoins.value);
        //gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.SetActive(false);
    }
}