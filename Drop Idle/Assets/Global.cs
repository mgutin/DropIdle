using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    private static double money = 0;

    private static GameObject protoBall = GameObject.Find("Ball");



    public static List<Ball> balls = new List<Ball>();

    public static void changeBallSizeProperty(float change)
    {
        
        float newSize = protoBall.transform.localScale.x + change;
        protoBall.transform.localScale = new Vector2(newSize, newSize);
    }


    public static void score(double amount)
    {
        money += amount;
        UI.moneyText.GetComponent<Text>().text = "$" + money;
    }

    public void Update()
    {
        
    }
}
