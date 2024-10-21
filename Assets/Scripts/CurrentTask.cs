using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentTask : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    GameStateManager gameStateManager;
    GameStateManager.TimeDay timeDay;
    TaskSlotsManager taskSlotsManager;

    private void Awake()
    {
        gameStateManager = FindObjectOfType<GameStateManager>();
        taskSlotsManager = FindObjectOfType<TaskSlotsManager>();
    }

    private void Update()
    {
        if(timeDay != gameStateManager.GetTimeDay())
        {
            switch(gameStateManager.GetTimeDay())
            {
                case GameStateManager.TimeDay.H9:
                    SetTaskName(TaskSlotsManager.TimelineSlots.H9);
                    taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H9).LockTask();
                    break;
                case GameStateManager.TimeDay.H12:
                    SetTaskName(TaskSlotsManager.TimelineSlots.H12);
                    taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H12).LockTask();
                    break;
                case GameStateManager.TimeDay.H15:
                    SetTaskName(TaskSlotsManager.TimelineSlots.H15);
                    taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H15).LockTask();
                    break;
                case GameStateManager.TimeDay.H18:
                    SetTaskName(TaskSlotsManager.TimelineSlots.H18);
                    taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H18).LockTask();
                    break;
                case GameStateManager.TimeDay.H21:
                    SetTaskName(TaskSlotsManager.TimelineSlots.H21);
                    taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H21).LockTask();
                    break;
            }
            timeDay = gameStateManager.GetTimeDay();
        }
    }

    public void StartCurrentTask()
    {
        SetTaskName(TaskSlotsManager.TimelineSlots.H9);
        timeDay = GameStateManager.TimeDay.H9;
        taskSlotsManager.GetTaskSlotAtTime(TaskSlotsManager.TimelineSlots.H9).LockTask();
    }

    private void SetTaskName(TaskSlotsManager.TimelineSlots timelineSlot)
    {
        if (taskSlotsManager.GetTaskAtTime(timelineSlot) != null)
        {
            text.text = taskSlotsManager.GetTaskAtTime(timelineSlot).name;
        }
        else
        {
            text.text = "No Task";
        }
    }
}
