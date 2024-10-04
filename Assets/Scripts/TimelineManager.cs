using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] TaskSlotsManager TaskSlotsManager;
    [SerializeField] Clock clock;
    bool activateTimeline = false;
    private void Update()
    {
        if(activateTimeline)
        {
            clock.UpdateTimer();
        }
    }
}
