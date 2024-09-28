using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TabsManager : MonoBehaviour
{
    private TasksManager taskManager;
    [SerializeField] GameObject socialTab;
    [SerializeField] GameObject workTab;
    [SerializeField] GameObject funTab;
    [SerializeField] GameObject ideasTab;
    [SerializeField] GameObject healthTab;

    [SerializeField] GameObject draggableTask;
    // Start is called before the first frame update

    [SerializeField] List<GameObject> tasksLoaded = new List<GameObject>();
    void Start()
    {
        taskManager = FindObjectOfType<TasksManager>();
        LoadSocial();
    }

    public void LoadSocial()
    {
        foreach(GameObject element in tasksLoaded)
        {
            Destroy(element);
        }
        tasksLoaded.Clear();
        socialTab.SetActive(true);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach(Task element in taskManager.UnlockedTasks)
        {
            if(element.taskCategory == Task.TaskCategory.SOCIAL)
            {
                GameObject newTask = Instantiate(draggableTask, transform);
                newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                newTask.GetComponent<DraggableTask>().SetTask(element);
                tasksLoaded.Add(newTask);
            }
        }
    }

    public void LoadWork()
    {
        foreach (GameObject element in tasksLoaded)
        {
            Destroy(element);
        }
        tasksLoaded.Clear();
        socialTab.SetActive(false);
        workTab.SetActive(true);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach (Task element in taskManager.UnlockedTasks)
        {
            if (element.taskCategory == Task.TaskCategory.WORK)
            {
                GameObject newTask = Instantiate(draggableTask, transform);
                newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                newTask.GetComponent<DraggableTask>().SetTask(element);
                tasksLoaded.Add(newTask);
            }
        }
    }

    public void LoadFun()
    {
        foreach (GameObject element in tasksLoaded)
        {
            Destroy(element);
        }
        tasksLoaded.Clear();
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(true);
        ideasTab.SetActive(false);
        healthTab.SetActive(false);
        foreach (Task element in taskManager.UnlockedTasks)
        {
            if (element.taskCategory == Task.TaskCategory.FUN)
            {
                GameObject newTask = Instantiate(draggableTask, transform);
                newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                newTask.GetComponent<DraggableTask>().SetTask(element);
                tasksLoaded.Add(newTask);
            }
        }
    }

    public void LoadIdeas()
    {
        foreach (GameObject element in tasksLoaded)
        {
            Destroy(element);
        }
        tasksLoaded.Clear();
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(true);
        healthTab.SetActive(false);
        foreach (Task element in taskManager.UnlockedTasks)
        {
            if (element.taskCategory == Task.TaskCategory.IDEAS)
            {
                GameObject newTask = Instantiate(draggableTask, transform);
                newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                newTask.GetComponent<DraggableTask>().SetTask(element);
                tasksLoaded.Add(newTask);
            }
        }
    }

    public void LoadHealth()
    {
        foreach (GameObject element in tasksLoaded)
        {
            Destroy(element);
        }
        tasksLoaded.Clear();
        socialTab.SetActive(false);
        workTab.SetActive(false);
        funTab.SetActive(false);
        ideasTab.SetActive(false);
        healthTab.SetActive(true);
        foreach (Task element in taskManager.UnlockedTasks)
        {
            if (element.taskCategory == Task.TaskCategory.HEALTH)
            {
                GameObject newTask = Instantiate(draggableTask, transform);
                newTask.GetComponentInChildren<TextMeshProUGUI>().text = element.name;
                newTask.GetComponent<DraggableTask>().SetTask(element);
                tasksLoaded.Add(newTask);
            }
        }
    }
    }
