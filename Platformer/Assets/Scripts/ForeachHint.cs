using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForeachHint : MonoBehaviour
{
    //This is the Foreach() version of this script, for the For() version look for the script "Hints"
    public Text hintText;
    private string[] hints;

    void Start()
    {
        hints = new string[8];

        hints[0] = "Press space to start jumping, your player will then continue to auto-jump after that!";
        hints[1] = "You can select the colored box or press numbers 1-3 to change your color!";
        hints[2] = "You can only take 3 hits before dying!";
        hints[3] = "Aim for the platforms, if you fall, you instantly die!";
        hints[4] = "The golden platform will launch you 3x higher than a normal jump!";
        hints[5] = "Collect the gold coins on your way up, you won't lose them on death!";
        hints[6] = "Don't touch the red X's, they will hurt you! Some can also move around!";
        hints[7] = "Confetti will fly when you break your high score!";

        StartCoroutine(changeHint());
    }


    IEnumerator changeHint()
    {
        while (true)
        {
            foreach(string hint in hints)
            {
                hintText.text = hint;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}