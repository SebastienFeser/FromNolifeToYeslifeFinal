using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskSlotsManager : MonoBehaviour
{
    [SerializeField] TaskSlot slot9h;
    [SerializeField] TaskSlot slot12h;
    [SerializeField] TaskSlot slot15h;
    [SerializeField] TaskSlot slot18h;
    [SerializeField] TaskSlot slot21h;

    public enum TimelineSlots
    {
        H9, H12, H15, H18, H21
    }
    
    public Task GetTaskAtTime(TimelineSlots timelineSlots)
    {
        switch(timelineSlots)
        {
            case TimelineSlots.H9:
                return slot9h.Task;
                break;
            case TimelineSlots.H12:
                return slot12h.Task;
                break;
            case TimelineSlots.H15:
                return slot15h.Task;
                break;
            case TimelineSlots.H18:
                return slot18h.Task;
                break;
            case TimelineSlots.H21:
                return slot21h.Task;
                break;
            default:
                return null;
        }
    }

    public TaskSlot GetTaskSlotAtTime(TimelineSlots timelineSlots)
    {
        switch (timelineSlots)
        {
            case TimelineSlots.H9:
                return slot9h;
                break;
            case TimelineSlots.H12:
                return slot12h;
                break;
            case TimelineSlots.H15:
                return slot15h;
                break;
            case TimelineSlots.H18:
                return slot18h;
                break;
            case TimelineSlots.H21:
                return slot21h;
                break;
            default:
                return null;
        }
    }

}
