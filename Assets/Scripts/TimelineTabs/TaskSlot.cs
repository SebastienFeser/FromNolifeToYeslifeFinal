using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class TaskSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Sprite taskedSprite;
    [SerializeField] Sprite unTaskedSprite;
    [SerializeField] Sprite lockedSprite;
    [SerializeField] Color taskedColor;
    [SerializeField] Color unTaskedColor;
    [SerializeField] GameObject deleteButton;
    PlayerManager playerManager;
    Task task;
    bool isLocked = false;

    public Task Task
    {
        get { return task; }
    }

    private void Start()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }
    public void DropTask(Task newTask)
    {
        if (!isLocked)
        {
            task = newTask;
            GetComponent<Image>().sprite = taskedSprite;
            TextMeshProUGUI textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
            textMeshProUGUI.text = task.name;
            textMeshProUGUI.color = taskedColor;
            deleteButton.SetActive(true);
        }
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

    public void LockTask()
    {
        GetComponent<Image>().sprite = lockedSprite;
        TextMeshProUGUI textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        textMeshProUGUI.color = unTaskedColor;
        deleteButton.SetActive(false);
        isLocked = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(task != null)
        {
            playerManager.TaskInfoBox.OpenTaskInfoBox(task);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        playerManager.TaskInfoBox.CloseTaskInfoBox();
    }
}
