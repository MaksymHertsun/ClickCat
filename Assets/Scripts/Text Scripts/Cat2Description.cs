using UnityEngine;
using UnityEngine.UI;

public class Cat2Description : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "$ " + Converter.ConvertMoney(CatsQuantity.cat2Price) + "\n+$ " + Converter.ConvertMoney(GameControl.cat2Get * CatsQuantity.cat2Quantity) + " /s";
    }
}
