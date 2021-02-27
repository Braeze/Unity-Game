using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCanvas : MonoBehaviour
{

    public Text textbox;
    public static int keyCount;

    void Start()
    {
        textbox = GetComponent<Text>();
    }

    void Update()
    {

        textbox.text = " " + keyCount;

    }
}