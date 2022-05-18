using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Converter : MonoBehaviour
{
    static float a, b;
    public static string ConvertMoney(long a1){
        a = a1;
        if ((1000 <= a && a < 1000000) || (-1000 >= a && a > -1000000)){
            b = a/1000;
            return Math.Round(b, 2) + " K";
        } else
        if ((1000000 <= a && a < 1000000000) || (-1000000 >= a && a > -1000000000)){
            b = a/1000000;
            return Math.Round(b, 2) + " M";
        } else
        if ((1000000000 <= a && a < 1000000000000) || (-1000000000 >= a && a > -1000000000000)){
            b = a/1000000000;
            return Math.Round(b, 2) + " B";
        } else
        if ((1000000000000 <= a && a < 1000000000000000) || (-1000000000000 >= a && a > -1000000000000000)){
            b = a/1000000000000;
            return Math.Round(b, 2) + " T";
        } else
        if ((1000000000000000 <= a && a < 1000000000000000000) || (-1000000000000000 >= a && a > -1000000000000000000)){
            b = a/1000000000000000;
            return Math.Round(b, 2) + " q";
        } else
        if (1000000000000000000 <= a || -1000000000000000000 >= a){
            b = a/1000000000000000000;
            return Math.Round(b, 2) + " Q";
        } else return a + "";
    }
}
