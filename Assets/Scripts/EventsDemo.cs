using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent OnTimerFinish;

    public float timerLength = 3;
    public float t;

    void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            OnTimerFinish.Invoke();
            t = 0;
        }
    }

    public void MouseEnterImage()
    {
        Debug.Log("mouse entered image");
        banana.localScale = Vector3.one * 1.2f;

    }

    public void MouseExitImage()
    {
        Debug.Log("mouse exited image");
        banana.localScale = Vector3.one;
    }
}
