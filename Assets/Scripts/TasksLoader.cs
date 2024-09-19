using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksLoader : MonoBehaviour
{
    Task[] newTaskList;

    private void Start()
    {
        LoadTasks();
    }

    public void LoadTasks()
    {
        newTaskList = Resources.LoadAll<Task>("Tasks");
    }
}
