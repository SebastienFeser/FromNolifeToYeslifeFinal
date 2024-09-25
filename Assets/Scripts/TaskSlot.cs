using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class TaskSlot : MonoBehaviour
{
    [SerializeField] Sprite taskedSprite;
    [SerializeField] Sprite unTaskedSprite;
    [SerializeField] Color taskedColor;
    [SerializeField] Color unTaskedColor;
    [SerializeField] GameObject deleteButton;
    Task task;

    public void DropTask(Task newTask)
    {
        task = newTask;
        GetComponent<Image>().sprite = taskedSprite;
        TextMeshProUGUI textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        textMeshProUGUI.text = task.name;
        textMeshProUGUI.color = taskedColor;
        deleteButton.SetActive(true);
    }
    
    public void DeleteTask()
    {
        task = null;
        GetComponent<Image>().sprite = unTaskedSprite;
        TextMeshProUGUI textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        textMeshProUGUI.text = "Drag a Task";
        textMeshProUGUI.color = unTaskedColor;
        deleteButton.SetActive(false);
    }
}
