using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerUp;

    float timer;

    bool powerUpOnScreen = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnTimer()
    {
        Vector2 pos = new Vector2(Random.Range(30, Screen.width-30), Random.Range(30, Screen.height-30));

        Vector2 screenPos = Camera.main.ScreenToWorldPoint(pos);

        while (timer < Random.Range(2,6))
        {
            timer += Time.deltaTime;
            yield return null;
        }
        Instantiate(powerUp, screenPos, Quaternion.identity);
        powerUpOnScreen = true;
    }
}
