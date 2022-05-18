using UnityEngine;
using UnityEngine.UI;

public class Cat1Quantity : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Converter.ConvertMoney(CatsQuantity.cat1Quantity) + "";
    }
}
