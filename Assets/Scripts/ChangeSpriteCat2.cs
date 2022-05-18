using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeSpriteCat2 : MonoBehaviour
{
    
    Image myImageComponent;
    public Sprite s1, s2;
    
    void Start()
    {
        myImageComponent = GetComponent<Image>();
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
    
      
    public void UpgradeCat2(){
        if(GameControl.cat2Lvl == 1 && Money.moneyAmount >= GameControl.cat2PriceToUp){
            ChangeToSprite1();
            
            Money.moneyAmount -= GameControl.cat2PriceToUp;
            GameControl.cat2Get *= 2;
            
            GameControl.cat2PriceToUp *= 100;
            GameControl.cat2Lvl++;
            
        } else

        if(GameControl.cat2Lvl == 2 && Money.moneyAmount >= GameControl.cat2PriceToUp){
            ChangeToSprite2();
            
            Money.moneyAmount -= GameControl.cat2PriceToUp;
            GameControl.cat2Get = Convert.ToInt32(GameControl.cat2Get * 1.5);
            GameControl.cat2Lvl++;
            
        }
    }
    
    void Update(){
        if(GameControl.cat2Lvl == 2) ChangeSpriteTo(s1);
        if(GameControl.cat2Lvl == 3) ChangeSpriteTo(s2);
    }

    public static void UpdateLVL(){
        
            if(GameControl.cat2Lvl == 2){
                
                GameControl.cat2Get *= 2;
                
                GameControl.cat2PriceToUp *= 100;
            } else if(GameControl.cat2Lvl == 3){
               
                GameControl.cat2Get = Convert.ToInt32(GameControl.cat2Get * 3);
            }
            
       
        
    }

   
}
