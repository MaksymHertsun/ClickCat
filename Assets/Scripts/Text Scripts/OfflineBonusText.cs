using UnityEngine;
using UnityEngine.UI;

public class OfflineBonusText : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "You get " + Converter.ConvertMoney(Money.offlineBonus);
    }
}
