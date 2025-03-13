using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelButton : MonoBehaviour
{
    public GameObject food;

    public RectTransform barrel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MouseEnterImage()
    {
        barrel.localScale = Vector3.one * 1.2f;
    }

    public void MouseExitImage()
    {
        barrel.localScale = Vector3.one;
    }

    public void MouseDown()
    {
        Instantiate(food);
    }
}
