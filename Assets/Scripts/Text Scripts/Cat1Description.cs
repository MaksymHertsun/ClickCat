using UnityEngine;
using UnityEngine.UI;

public class Cat1Description : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "$ " + Converter.ConvertMoney(CatsQuantity.cat1Price) + "\n+$ " + Converter.ConvertMoney(GameControl.cat1Get * CatsQuantity.cat1Quantity) + " /s";
    }
}
