using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DraggableTask : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject taskGameobject;

    GameObject instantiatedTask;
    Task task;
    GraphicRaycaster graphicRaycaster;
    PointerEventData pointerEventData;
    EventSystem eventSystem;

    private void Start()
    {
        graphicRaycaster = GameObject.FindWithTag("TaskSlots").GetComponent<GraphicRaycaster>(); ;
        eventSystem = FindObjectOfType<EventSystem>();
        Debug.Log(graphicRaycaster.gameObject.name);
        Debug.Log(eventSystem);
    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        instantiatedTask = Instantiate(taskGameobject, transform.parent);
        instantiatedTask.transform.SetParent(transform.root);
        instantiatedTask.transform.SetAsLastSibling();
        instantiatedTask.GetComponentInChildren<TextMeshProUGUI>().text = this.GetComponentInChildren<TextMeshProUGUI>().text;
        instantiatedTask.GetComponent<DraggedTask>().StartDraggedTask(task);
    }

    public void OnDrag(PointerEventData eventData)
    {
        instantiatedTask.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        pointerEventData = new PointerEventData(eventSystem);
        pointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();

        graphicRaycaster.Raycast(pointerEventData, results);
        foreach(RaycastResult result in results)
        {
            Debug.Log(gameObject.name);
            if(result.gameObject.tag == "TimelineButton")
            {
                result.gameObject.GetComponent<TaskSlot>().DropTask(task);
            }
        }
        Destroy(instantiatedTask);
    }

    public void SetTask(Task newTask)
    {
        task = newTask;
    }
}
