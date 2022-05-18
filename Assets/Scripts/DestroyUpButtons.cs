using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUpButtons : MonoBehaviour
{
    public GameObject UpgradeButton1, UpgradeButton2, UpgradeButton3, TextCat1, TextCat2, TextCat3, Panel; 
    private bool isUpButon1Exist = true, isUpButon2Exist = true, isUpButon3Exist = true, isPanelExist = true;

    

    
    void Update(){
        if (GameControl.cat1Lvl == 3 && isUpButon1Exist){
            Destroy(UpgradeButton1);
            Destroy(TextCat1);
            isUpButon1Exist = false;
        }
        if (GameControl.cat2Lvl == 3 && isUpButon2Exist){
            Destroy(UpgradeButton2);
            Destroy(TextCat2);
            isUpButon2Exist = false;
        }
        if (GameControl.cat3Lvl == 3 && isUpButon3Exist){
            Destroy(UpgradeButton3);
            Destroy(TextCat3);
            isUpButon3Exist = false;
        }
        if (isPanelExist && Input.GetMouseButtonDown(0)){
            Destroy(Panel);
            isPanelExist = false;
        }
        
    }
}
