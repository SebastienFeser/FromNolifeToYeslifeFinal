using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class TaskSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] Sprite taskedSprite;
    [SerializeField] Sprite unTaskedSprite;
    [SerializeField] Color taskedColor;
    [SerializeField] Color unTaskedColor;
    Task task;

    public void DropTask(Task newTask)
    {
        task = newTask;
        GetComponent<Image>().sprite = taskedSprite;
        TextMeshProUGUI textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        textMeshProUGUI.text = task.name;
        textMeshProUGUI.color = taskedColor;
    }
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Dropped");
        //GameObject dropped = eventData.pointerDrag;
        //Debug.Log(dropped.GetComponent<DraggedTask>());
        //task = dropped.GetComponent<DraggedTask>().task;
        //GetComponent<Image>().sprite = taskedSprite;
        //GetComponentInChildren<TextMeshProUGUI>().text = task.name;
    }
}
