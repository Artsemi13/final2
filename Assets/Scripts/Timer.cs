using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private bool isTimerStart = false;
    private float timer;

    void Update()
    {
        if (isTimerStart == true)
        {
            timer += Time.deltaTime;
        }
        print(timer);
    }

    public void StartTimer()
    {
        isTimerStart = true;
    }

    public void StopTimer()
    {
        isTimerStart = false;
    }

}
