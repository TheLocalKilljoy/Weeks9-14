using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public Transform hHand;
    public Transform mHand;

    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public UnityEvent<int> OnTheHour;

    Coroutine clockRunning;
    IEnumerator do1hr;

    void Start()
    {
        clockRunning = StartCoroutine(MoveClock());
    }

    IEnumerator MoveClock()
    {
        while (true)
        {
            do1hr = MoveClockByHr();
            yield return StartCoroutine(do1hr);
        }
    }

    IEnumerator MoveClockByHr()
    {
        t = 0;
        while (t < timeAnHourTakes) 
        {
            t += Time.deltaTime;
            mHand.Rotate(0,0,-(360/timeAnHourTakes) * Time.deltaTime);
            hHand.Rotate(0, 0, -(30/timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        hour ++;
        if (hour == 13)
        {
            hour = 1;
        }
        OnTheHour.Invoke(hour);
    }

    public void StopClock()
    {
        if (clockRunning != null)
        {
            StopCoroutine(clockRunning);
        }
        if (do1hr != null)
        {
            StopCoroutine(do1hr);
        }
    }
}
