using UnityEngine;
using UnityEngine.UI;
public class LoadWindowTextScript : MonoBehaviour
{
    private  Text text;
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    
    void Update()
    {
        text.text = TimeSystem.hours + "\n" + TimeSystem.minutes + "\n" + TimeSystem.seconds;
    }
}
