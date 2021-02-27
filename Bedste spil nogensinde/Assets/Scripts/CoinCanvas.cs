using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCanvas : MonoBehaviour
{

    public Text textbox;
    public static int coinsCount;

    void Start()
    {
        textbox = GetComponent<Text>();
    }

    void Update()
    {
        //lav et script til alt counting af værdier

        textbox.text = " " + coinsCount;

    }
}