using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static float timeRemaining = 1f;
    public static int cat1Get = 1, cat2Get = 10, cat3Get = 150, productivity, cat1NeedsToUp = 100, cat2NeedsToUp = 100, cat3NeedsToUp = 100,
    cat1PriceToUp = 100000, cat2PriceToUp = 1000000, cat3PriceToUp = 10000000, cat1Lvl = 1, cat2Lvl = 1, cat3Lvl = 1, bonus = 1;
    private float timer = timeRemaining;
  
    

    
    void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
        }
        else {
            timer = timeRemaining;
            PlusMoney();
        }
    }

   
    void PlusMoney(){
        productivity = ((cat1Get*CatsQuantity.cat1Quantity) + (cat2Get*CatsQuantity.cat2Quantity) + (cat3Get*CatsQuantity.cat3Quantity)) * bonus;
        Money.moneyAmount += productivity;
        
    }
    
}
