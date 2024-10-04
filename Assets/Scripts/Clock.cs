using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    [SerializeField] float timeMultiplier;
    float timeSpeedMultiplier;
    int hoursDisplayed;
    int minutesDisplayed;
    float minutes;


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
        minutes += Time.deltaTime * timeMultiplier * timeSpeedMultiplier;
        if(minutes > 1f )
        {
            if(minutes >= 59)
            {
                hoursDisplayed++;
                minutes = 0f;
            }
            else
            {
                minutes++;
            }
            minutes -= 1f;
        }
    }
}
