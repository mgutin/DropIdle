using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{



    public static GameObject moneyText = GameObject.Find("MoneyText");

    public static GameObject sizeText = GameObject.Find("MoneyText");

    public static bool debug = true;

    public static void changeSize(float amount)
    {
        Global.changeBallSizeProperty(amount);
        sizeText.GetComponent<Text>().text = "Size  " + getSizeString(amount);
    }

    private static string getSizeString(float amount)
    {
        amount *= 1000;
        string output = amount.ToString().Substring(0, 4);
        while(output.EndsWith("0") || output.EndsWith("."))
        {
            if(output.Length == 0)
            {
                break;
            }
            output = output.Substring(0, output.Length - 1);
        }
        return output;
    }
     
}
