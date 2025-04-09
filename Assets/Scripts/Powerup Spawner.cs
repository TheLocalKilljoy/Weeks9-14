using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2 (Random.Range(0, Screen.width), Random.Range(0,Screen.height));

        Vector2 screenPos = Camera.main.ScreenToWorldPoint(pos);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(powerUp, screenPos, Quaternion.identity);
        }
    }
}
