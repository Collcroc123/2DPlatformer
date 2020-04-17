﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    public Text coinText;
    public IntData totalCoins;

    void Update()
    {
        coinText.text = totalCoins.value.ToString();
    }
}
