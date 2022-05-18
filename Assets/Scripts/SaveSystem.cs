using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SaveSystem : MonoBehaviour
{
    
    int productivity;
    void Start()
    {
        if (PlayerPrefs.HasKey("Money")) Money.moneyToSave = PlayerPrefs.GetString("Money");
        if (PlayerPrefs.HasKey("Cat1Quantity")) CatsQuantity.cat1Quantity = PlayerPrefs.GetInt("Cat1Quantity");
        if (PlayerPrefs.HasKey("Cat2Quantity")) CatsQuantity.cat2Quantity = PlayerPrefs.GetInt("Cat2Quantity");
        if (PlayerPrefs.HasKey("Cat3Quantity")) CatsQuantity.cat3Quantity = PlayerPrefs.GetInt("Cat3Quantity");
        if (PlayerPrefs.HasKey("Cat1Lvl")) GameControl.cat1Lvl = PlayerPrefs.GetInt("Cat1Lvl");
        if (PlayerPrefs.HasKey("Cat2Lvl")) GameControl.cat2Lvl = PlayerPrefs.GetInt("Cat2Lvl");
        if (PlayerPrefs.HasKey("Cat3Lvl")) GameControl.cat3Lvl = PlayerPrefs.GetInt("Cat3Lvl");
        if (PlayerPrefs.HasKey("productivity")) productivity = PlayerPrefs.GetInt("productivity");
        ChangeSpriteCat1.UpdateLVL();
        ChangeSpriteCat2.UpdateLVL();
        ChangeSpriteCat3.UpdateLVL();
                
        Money.offlineBonus = TimeSystem.secondsOffline * productivity;
        Money.moneyAmount = long.Parse(Money.moneyToSave) + Money.offlineBonus;
        

    }

    
    void Update()
    {
        PlayerPrefs.SetString("Money", Money.moneyToSave);
        PlayerPrefs.SetInt("Cat1Quantity", CatsQuantity.cat1Quantity);
        PlayerPrefs.SetInt("Cat2Quantity", CatsQuantity.cat2Quantity);
        PlayerPrefs.SetInt("Cat3Quantity", CatsQuantity.cat3Quantity);
        PlayerPrefs.SetInt("Cat1Lvl", GameControl.cat1Lvl);
        PlayerPrefs.SetInt("Cat2Lvl", GameControl.cat2Lvl);
        PlayerPrefs.SetInt("Cat3Lvl", GameControl.cat3Lvl);
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        PlayerPrefs.SetInt("productivity", GameControl.productivity);

        //PlayerPrefs.DeleteAll();
        
    }
    
    
}
