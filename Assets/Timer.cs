using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] float startTime = 60f;
    [SerializeField] Slider slider1;
    [SerializeField] TextMeshProUGUI timerText1;

    float timer1 = 0f;

    // Start is called
    void Start()
    {
        StartCoroutine(Timer1());
    }

    private IEnumerator Timer1()
    {
        timer1 = startTime;

        do
        {
            //Execute Countdown
            timer1 -= Time.deltaTime;
            slider1.value = timer1 / startTime;
            FormatText1();
            yield return null;
        }
        
        while (timer1 > 0);
    }

    private void FormatText1()
    {
        int minutes = (int)(timer1 / 60) % 60;
        int seconds = (int)(timer1 % 60);

        timerText1.text = "";
        if (minutes > 0) { timerText1.text += minutes + "m "; }
        if (seconds > 0) { timerText1.text += seconds + "s "; }
    }
}
