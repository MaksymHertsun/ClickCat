using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeSpriteCat1 : MonoBehaviour
{
    
    Image myImageComponent;
    public Sprite s1, s2;

    
    
    void Start()
    {
        myImageComponent = GetComponent<Image>();
        
    }

    void Update(){
        if(GameControl.cat1Lvl == 2) ChangeSpriteTo(s1);
        if(GameControl.cat1Lvl == 3) ChangeSpriteTo(s2);
    }

    public static void UpdateLVL(){
        
            if(GameControl.cat1Lvl == 2){
                
                GameControl.cat1Get *= 2;
                
                GameControl.cat1PriceToUp *= 100;
            } else if(GameControl.cat1Lvl == 3){
               
                GameControl.cat1Get = Convert.ToInt32(GameControl.cat1Get * 3);
            }
            
       
        
    }

    private void ChangeSpriteTo(Sprite sprite){
        myImageComponent.sprite = sprite;
        
    }

    private void ChangeToSprite1(){
        ChangeSpriteTo(s1);
    }
    private void ChangeToSprite2(){
        ChangeSpriteTo(s2);
    }
    
    
    
    
    

    public void UpgradeCat1(){
        if(GameControl.cat1Lvl == 1 && Money.moneyAmount >= GameControl.cat1PriceToUp){
            ChangeToSprite1();
            
            Money.moneyAmount -= GameControl.cat1PriceToUp;
            GameControl.cat1Get *= 2;
            
            GameControl.cat1PriceToUp *= 100;
            GameControl.cat1Lvl++;
            
           
        } else

        if(GameControl.cat1Lvl == 2 && Money.moneyAmount >= GameControl.cat1PriceToUp){
            ChangeToSprite2();
            
            Money.moneyAmount -= GameControl.cat1PriceToUp;
            GameControl.cat1Get = Convert.ToInt32(GameControl.cat1Get * 1.5);
            GameControl.cat1Lvl++;
            
        }
    }
   
    


   
}
