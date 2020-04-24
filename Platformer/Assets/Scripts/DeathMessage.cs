using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMessage : MonoBehaviour
{
    private int switchInt;
    private string deathMessage;
    public Height hgt;
    public Text death;

    void Update()
    {
        if (hgt.currentBest < 10)
        {
            switchInt = 1;
        }
        else if (hgt.currentBest >= 10f && hgt.currentBest < 25f)
        {
            switchInt = 2;
        }
        else if (hgt.currentBest >= 25f && hgt.currentBest < 50f)
        {
            switchInt = 3;
        }
        else if (hgt.currentBest >= 50f && hgt.currentBest < 75f)
        {
            switchInt = 4;
        }
        else if (hgt.currentBest >= 75f && hgt.currentBest < 100f)
        {
            switchInt = 5;
        }
        else if (hgt.currentBest >= 100f)
        {
            switchInt = 6;
        }
        else
        {
            print("ERROR: Cannot access height!");
            return;
        }

        DeathSwitch();
        death.text = deathMessage;
    }

    void DeathSwitch()
    {
        switch (switchInt)
        {
            default:
                deathMessage = "Impossible Number, Please Restart";
                break;
            case 1:
                deathMessage = "How even??? Try again!!!";
                break;
            case 2:
                deathMessage = "Keep trying!";
                break;
            case 3:
                deathMessage = "Gettin' the hang of it!";
                break;
            case 4:
                deathMessage = "To Everest we go!";
                break;
            case 5:
                deathMessage = "Reach for the stars!";
                break;
            case 6:
                deathMessage = "Thank you for playing!";
                break;
        }
    }
}
