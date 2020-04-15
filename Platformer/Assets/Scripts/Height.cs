using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Height : MonoBehaviour
{
    public GameObject player;
    public float currentHeight;
    public Text heightText;
    public Text highScoreText;
    private float currentBest = 0f;
    public IntData highScore;

    //https://answers.unity.com/questions/123790/float-to-int.html

    void Update()
    {
        currentHeight = player.transform.position.y;
        if (currentHeight > currentBest)
        {
            heightText.text = Mathf.FloorToInt(currentHeight).ToString() + " m";
            currentBest = currentHeight;
        }
        if (currentHeight > highScore.value)
        {
            highScore.value = Mathf.FloorToInt(currentHeight);
        }
        highScoreText.text = highScore.value.ToString() + " m";
    }
}
