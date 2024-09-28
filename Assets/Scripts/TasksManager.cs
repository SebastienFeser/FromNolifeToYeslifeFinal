using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasksManager : MonoBehaviour
{
    List<Task> unlockedTasks = new List<Task>();

    public List<Task> UnlockedTasks
    {
        get { return unlockedTasks; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadTasks(Task[] tasksToLoad)
    {
        foreach(Task element in tasksToLoad)
        {
            if(element.isUnlocked)
            {
                unlockedTasks.Add(element);
            }
        }
    }

    public void AddTask(Task task)
    {
        unlockedTasks.Add(task);
    }
}
