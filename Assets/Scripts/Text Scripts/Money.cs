using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
   Text text;   
   public static long moneyAmount, offlineBonus;
   public static string moneyToSave; 
   
   void Start()
    {
        text = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "$ " + Converter.ConvertMoney(moneyAmount);
        moneyToSave = moneyAmount.ToString();
    }
}
