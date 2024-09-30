using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Task/New Task")]
public class Task : ScriptableObject
{
    public enum TaskCategory
    {
        SOCIAL,
        WORK,
        FUN,
        IDEAS,
        HEALTH
    }

    public string name;
    public string description;
    public TaskCategory taskCategory;

    public int physicalConditionOutput;
    public int motivationOutput;
    public int societalIntegrationOutput;
    public int sociableOutput;
    public int moneyOutput;
    public int mentalHealthOutput;
    public int ideasOutput;

    public bool isUnlocked;
    public bool hasQTE;
}
