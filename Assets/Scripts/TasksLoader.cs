using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksLoader : MonoBehaviour
{
    Task[] newTaskList;
    TasksManager tasksManager;

    private void Awake()
    {
        LoadTasks();
        tasksManager = FindObjectOfType<TasksManager>();
        tasksManager.LoadTasks(newTaskList);
    }

    public void LoadTasks()
    {
        newTaskList = Resources.LoadAll<Task>("Tasks");
    }
}
