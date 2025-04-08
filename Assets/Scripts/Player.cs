using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turn();
    }

    void turn()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * 0;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = Vector3.forward * 90;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.forward * -90;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = Vector3.forward * 180;
        }
    }
}
