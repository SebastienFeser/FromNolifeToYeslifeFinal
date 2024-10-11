using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{

    [SerializeField] float timeMultiplier;
    [SerializeField] TextMeshProUGUI text;
    float timeSpeedMultiplier;
    int hoursDisplayed;
    int minutesDisplayed;
    float minutes;


    public void StartTime()
    {
        hoursDisplayed = 9;
        minutesDisplayed = 0;
        minutes = 0;
        text.text = hoursDisplayed.ToString("D2") + ":" + minutesDisplayed.ToString("D2");
    }

    public void X0TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 0;
    }

    public void X1TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 1;
    }

    public void X2TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 2;
    }

    public void X3TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 4;
    }

    public void UpdateTimer()
    {
        text.text = hoursDisplayed.ToString("D2") + ":" + minutesDisplayed.ToString("D2");
        minutes += Time.deltaTime * timeMultiplier * timeSpeedMultiplier;
        if(minutes > 1f )
        {
            if(minutesDisplayed >= 59)
            {
                hoursDisplayed++;
                minutesDisplayed = 0;
            }
            else
            {
                minutesDisplayed++;
            }
            minutes -= 1f;
        }
    }
}
