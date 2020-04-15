using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int timePassed = 0;
    private bool dontCount = false;
    public CharacterMovement charMove;
    public Text timerText;
    
    void Update()
    {
        if(charMove.startJumping)
        {
            if(dontCount == false)
            {
                StartCoroutine(Countdown());
            }
        }
    }
    IEnumerator Countdown()
    {
        dontCount = true;
        while (enabled)
        {
            yield return new WaitForSeconds(1.0f);
            timePassed += 1;
            timerText.text = timePassed.ToString();
        }
    }
}