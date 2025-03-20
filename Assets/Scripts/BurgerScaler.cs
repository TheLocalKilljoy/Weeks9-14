using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerScaler : MonoBehaviour
{
    public Transform burger;

    public AnimationCurve scaler;

    public float scaleTimer = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(scaleBurger());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator scaleBurger()
    {
        while (scaleTimer < 2)
        {
            scaleTimer += Time.deltaTime;
            burger.localScale = Vector3.one * scaler.Evaluate(scaleTimer);
            yield return null;

        }
    }
}
