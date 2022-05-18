using UnityEngine;
using UnityEngine.UI;

public class Cat3Description : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "$ " + Converter.ConvertMoney(CatsQuantity.cat3Price) + "\n+$ " + Converter.ConvertMoney(GameControl.cat3Get * CatsQuantity.cat3Quantity) + " /s";
    }
}
