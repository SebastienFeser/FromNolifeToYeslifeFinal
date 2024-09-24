using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggedTask : MonoBehaviour
{
    public Task task;
    
    public void StartDraggedTask(Task newTask)
    {
        task = newTask;
    }
}
