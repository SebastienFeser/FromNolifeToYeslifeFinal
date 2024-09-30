using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    List<Task> unlockedTasks = new List<Task>();


    int ideas;
    int mentalHealth;
    int money;

    int pysicalCondition;
    int motivation;
    int societalIntegration;
    int sociable;

    [SerializeField] TaskInfoBox taskInfoBox;

    public TaskInfoBox TaskInfoBox
    {
        get { return taskInfoBox; }
    }

    public int IdeaPoints
    {
        get { return ideas; }
    }
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
        foreach (Task element in tasksToLoad)
        {
            if (element.isUnlocked)
            {
                unlockedTasks.Add(element);
            }
        }
    }

    public void AddTask(Task task)
    {
        unlockedTasks.Add(task);
    }

    public void SpendIdeaPoints(int quantity)
    {
        ideas -= quantity;
    }
}
