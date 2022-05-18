using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeSpriteCat3 : MonoBehaviour
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
    
     
    public void UpgradeCat3(){
        if(GameControl.cat3Lvl == 1 && Money.moneyAmount >= GameControl.cat3PriceToUp){
            ChangeToSprite1();
            
            Money.moneyAmount -= GameControl.cat3PriceToUp;
            GameControl.cat3Get *= 2;
            
            GameControl.cat3PriceToUp *= 100;
            GameControl.cat3Lvl++;
            
        } else

        if(GameControl.cat3Lvl == 2 && Money.moneyAmount >= GameControl.cat3PriceToUp){
            ChangeToSprite2();
            
            Money.moneyAmount -= GameControl.cat3PriceToUp;
            GameControl.cat3Get = Convert.ToInt32(GameControl.cat3Get * 1.5);
            GameControl.cat3Lvl++;
            
        }
    }
    void Update(){
        if(GameControl.cat3Lvl == 2) ChangeSpriteTo(s1);
        if(GameControl.cat3Lvl == 3) ChangeSpriteTo(s2);
    }

    public static void UpdateLVL(){
        
            if(GameControl.cat3Lvl == 2){
                
                GameControl.cat3Get *= 2;
                
                GameControl.cat3PriceToUp *= 100;
            } else if(GameControl.cat3Lvl == 3){
               
                GameControl.cat3Get = Convert.ToInt32(GameControl.cat3Get * 3);
            }
            
       
        
    }


   
}
