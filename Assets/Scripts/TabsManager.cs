using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TabsManager : MonoBehaviour
{
    private TasksLoader tasksLoader;
    [SerializeField] GameObject socialTab;
    [SerializeField] GameObject workTab;
    [SerializeField] GameObject funTab;
    [SerializeField] GameObject ideasTab;
    [SerializeField] GameObject healthTab;

    [SerializeField] GameObject draggableTask;
    // Start is called before the first frame update
    void Start()
    {
        tasksLoader = FindObjectOfType<TasksLoader>();
        LoadSocial();
    }

    public void LoadSocial()
    {
        socialTab.SetActive(true);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach(Task element in tasksLoader.NewTaskList)
        {
            if(element.isUnlocked)
            {
                if(element.taskCategory == Task.TaskCategory.SOCIAL)
                {
                    GameObject newTask = Instantiate(draggableTask, transform);
                    newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                }
            }
        }
    }

    public void LoadWork()
    {
        socialTab.SetActive(false);
        workTab.SetActive(true);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach (Task element in tasksLoader.NewTaskList)
        {
            if (element.isUnlocked)
            {
                if (element.taskCategory == Task.TaskCategory.WORK)
                {
                    GameObject newTask = Instantiate(draggableTask);
                    newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                }
            }
        }
    }

    public void LoadFun()
    {
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(true);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach (Task element in tasksLoader.NewTaskList)
        {
            if (element.isUnlocked)
            {
                if (element.taskCategory == Task.TaskCategory.FUN)
                {
                    GameObject newTask = Instantiate(draggableTask);
                    newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                }
            }
        }
    }

    public void LoadIdeas()
    {
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(true);
        healthTab.SetActive(false);
        foreach (Task element in tasksLoader.NewTaskList)
        {
            if (element.isUnlocked)
            {
                if (element.taskCategory == Task.TaskCategory.IDEAS)
                {
                    GameObject newTask = Instantiate(draggableTask);
                    newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                }
            }
        }
    }

    public void LoadHealth()
    {
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(true);
        foreach (Task element in tasksLoader.NewTaskList)
        {
            if (element.isUnlocked)
            {
                if (element.taskCategory == Task.TaskCategory.HEALTH)
                {
                    GameObject newTask = Instantiate(draggableTask);
                    newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                }
            }
        }
    }
    }
