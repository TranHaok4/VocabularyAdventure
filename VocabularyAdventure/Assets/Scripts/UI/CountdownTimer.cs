using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : HaroMonobehavior
{
    [SerializeField] protected float currentTime = 0f;
    [SerializeField] protected float countdownTime = 15f;

    [SerializeField] protected Text countdownText;

    private bool shouldCountdown = true;

    protected override void OnEnable()
    {
        base.OnEnable();
        currentTime = countdownTime;
    }

    private void Update()
    {
        if (shouldCountdown)
        {
            currentTime -= Time.unscaledDeltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime <= 0)
            {
                currentTime = 0;
                shouldCountdown = false; 
                QuizManager.Instance.TimeOut();
            }
        }
    }

    public void StartCountdown()
    {
        shouldCountdown = true;
    }

    public void StopCountdown()
    {
        shouldCountdown = false;
    }
}
