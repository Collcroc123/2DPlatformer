using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Height : MonoBehaviour
{
    public GameObject player;
    public float currentHeight;
    public Text heightText;
    public Text highScoreText;
    private float currentBest = 0f;
    public IntData highScore;
    private bool brokeRecord = false;
    public UnityEvent confetti;

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
            if(brokeRecord == false)
            {
                confetti.Invoke();
                brokeRecord = true;
            }
        }
        highScoreText.text = highScore.value.ToString() + " m";
    }
}
