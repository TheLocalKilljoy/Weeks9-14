using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float pos;
    float speed = 10;

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
        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * 0;
            transform.localPosition += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = Vector3.forward * 90;
            transform.localPosition += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = Vector3.forward * -90;
            transform.localPosition += Vector3.right * Time.deltaTime * speed;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = Vector3.forward * 180;
            transform.localPosition += Vector3.down * Time.deltaTime * speed;

        }
    }

    void Move()
    {
        
    }
}
