using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    private Transform background;
    public float speed = 5f;
    void Start()
    {
        background = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        background.Rotate(0, 0, speed * Time.deltaTime);
    }
}
