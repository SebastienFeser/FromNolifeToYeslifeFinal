using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] TaskSlotsManager TaskSlotsManager;
    [SerializeField] Clock clock;
    [SerializeField] GameObject startDay;
    [SerializeField] CurrentTask currentTask;
    bool activateTimeline = false;
    private void Update()
    {
        if(activateTimeline)
        {
            clock.UpdateTimer();
        }
    }

    public void PreStartTimeline()
    {
        clock.StartTime();
    }

    public void StartTimeline()
    {
        activateTimeline = true;
        startDay.SetActive(false);
        clock.X1TimeSpeedMultiplier();
        currentTask.StartCurrentTask();
    }
}
