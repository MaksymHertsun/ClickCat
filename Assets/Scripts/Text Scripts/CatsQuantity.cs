using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatsQuantity : MonoBehaviour
{
    
   
    public static int cat1Quantity, cat2Quantity, cat3Quantity, cat1Price = 0, cat2Price, cat3Price;
   
    
    
    void Start()
    {
        
       
    }

    
    void Update()
    {
       
       cat2Price = 10000 + (cat2Quantity * 100);
       cat3Price = 100000 + (cat3Quantity * 1000);
       
        
    }
    public void PlusCat1(){
        
            cat1Quantity ++;
           
              
    }
    
    public void PlusCat2(){
        if (Money.moneyAmount >= cat2Price){
            cat2Quantity ++;
            Money.moneyAmount -= cat2Price;
        }
        
    }
    public void PlusCat3(){
        if (Money.moneyAmount >= cat3Price){
            cat3Quantity ++;
            Money.moneyAmount -= cat3Price;
        }
        
    }
  
}
