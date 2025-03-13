using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClockRotator : MonoBehaviour
{
    Vector3 rot;

    public float speed = 10;

    public UnityEvent OnTimerFinish;

    public float timerLength = 10;
    public float t;

    // Update is called once per frame
    void Update()
    {
        rot = transform.eulerAngles;

        rot.z += Time.deltaTime * -speed;

        transform.eulerAngles = rot;

        t += Time.deltaTime * speed / 120;
        if (t > timerLength)
        {
            Debug.Log("ding dong");
            OnTimerFinish.Invoke();
            t = 0;
        }
    }
}
