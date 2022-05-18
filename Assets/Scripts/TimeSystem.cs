using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeSystem : MonoBehaviour
{
    private void Awake(){
        CheckOfline();
    }
    public static int hours, minutes, seconds;
    public static long secondsOffline;
    private void CheckOfline(){
        TimeSpan ts;
        if (PlayerPrefs.HasKey("LastSession")){
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            
            secondsOffline = ((ts.Days * 86400) + (ts.Hours * 3600) + (ts.Minutes * 60) + ts.Seconds);
            if (secondsOffline > 14400) {
                
                secondsOffline = 14400;
                hours = 4;
                minutes = 0;
                seconds = 0;

            } else{
                hours = ts.Hours;
                minutes = ts.Minutes;
                seconds = ts.Seconds;
            }
            
            

        }
        

    }
    
}
