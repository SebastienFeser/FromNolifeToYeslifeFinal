using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksLoader : MonoBehaviour
{
    Task[] newTaskList;

    public Task[] NewTaskList
    {
        get { return newTaskList; }
    }

    private void Awake()
    {
        LoadTasks();
    }

    public void LoadTasks()
    {
        newTaskList = Resources.LoadAll<Task>("Tasks");
    }
}
