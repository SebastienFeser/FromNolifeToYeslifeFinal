using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksLoader : MonoBehaviour
{
    Task[] newTaskList;
    PlayerManager playerManager;

    private void Awake()
    {
        LoadTasks();
        playerManager = FindObjectOfType<PlayerManager>();
        playerManager.LoadTasks(newTaskList);
    }

    public void LoadTasks()
    {
        newTaskList = Resources.LoadAll<Task>("Tasks");
    }
}
