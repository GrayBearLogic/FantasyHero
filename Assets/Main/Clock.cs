using System;
using UnityEngine;
using UnityEngine.Events;

public class Clock : MonoBehaviour
{
    [SerializeField] private float period = 1f;
    [Range(0f, 0.99f)]
    [SerializeField] private float phase = 0f;

    [SerializeField] private UnityEvent onTimerCount;

    private float time;

    private void Awake()
    {
        time = (1f - phase) * period;
    }

    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = period;
            onTimerCount.Invoke();
        }
        
    }
}
