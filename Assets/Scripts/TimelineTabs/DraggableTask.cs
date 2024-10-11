using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DraggableTask : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject taskGameobject;
    [SerializeField] GameObject screenHover;

    GameObject instantiatedTask;
    Task task;
    GraphicRaycaster graphicRaycaster;
    PointerEventData pointerEventData;
    EventSystem eventSystem;
    PlayerManager playerManager;

    bool isHovered = false;
    bool isDragging = false;

    private void Start()
    {
        graphicRaycaster = GameObject.FindWithTag("TaskSlots").GetComponent<GraphicRaycaster>(); ;
        eventSystem = FindObjectOfType<EventSystem>();
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {
       
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        instantiatedTask = Instantiate(taskGameobject, transform.parent);
        instantiatedTask.transform.SetParent(transform.root);
        instantiatedTask.transform.SetAsLastSibling();
        instantiatedTask.GetComponentInChildren<TextMeshProUGUI>().text = this.GetComponentInChildren<TextMeshProUGUI>().text;
        instantiatedTask.GetComponent<DraggedTask>().StartDraggedTask(task);
        isDragging = true;
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
        isDragging = false;
    }

    public void SetTask(Task newTask)
    {
        task = newTask;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
        playerManager.TaskInfoBox.OpenTaskInfoBox(task);
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        playerManager.TaskInfoBox.CloseTaskInfoBox();
        isHovered = false;
    }
}
