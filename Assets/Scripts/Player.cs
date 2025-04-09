using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 pos = transform.localPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);


        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = Vector3.forward * 0;

            if (screenPos.y+30 < Screen.height)
            {
                pos = transform.localPosition + Vector3.up * Time.deltaTime * speed;
                transform.localPosition = pos;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = Vector3.forward * 90;

            if (screenPos.x-30 > 0)
            {
                pos = transform.localPosition + Vector3.left * Time.deltaTime * speed;
                transform.localPosition = pos;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = Vector3.forward * -90;

            if (screenPos.x + 30 < Screen.width)
            {
                pos = transform.localPosition + Vector3.right * Time.deltaTime * speed;
                transform.localPosition = pos;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = Vector3.forward * 180;

            if (screenPos.y - 30 > 0)
            {
                pos = transform.localPosition + Vector3.down * Time.deltaTime * speed;
                transform.localPosition = pos;
            }
        }
    }
}
