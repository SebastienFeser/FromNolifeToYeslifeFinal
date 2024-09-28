using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TechTree : MonoBehaviour
{
    [SerializeField] Transform techTreeTransform;
    Vector2 startPosition;
    Vector2 offset;
    private Vector3 mouseOrigin;
    [SerializeField] TechSlot startSlot;
    TechSlot registeredTechSlot;
    [SerializeField] GameObject techSlotValidation;
    TasksManager tasksManager;

    void Awake()
    {
        startPosition = techTreeTransform.position;
        tasksManager = FindObjectOfType<TasksManager>();
    }
    private void Start()
    {
        startSlot.UnlockTechnology();
    }

    void Update()
    {
        MoveTechTree();
    }

    private void MoveTechTree()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //mouseOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            offset = techTreeTransform.position - Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            //Vector3 difference = mouseOrigin - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //techTreeTransform.position += difference;
            Vector2 cameraMousePosition = Input.mousePosition;
            techTreeTransform.position = cameraMousePosition + offset;
        }
    }

    public void QuitTechTree()
    {
        techTreeTransform.position = startPosition;
        gameObject.SetActive(false);
    }

    public void BuyTechnology(TechSlot techSlot)
    {
        registeredTechSlot = techSlot;
        techSlotValidation.SetActive(true);
    }

    public void ValidateTechnologyBuy()
    {
        registeredTechSlot.BuyTechnology();
        tasksManager.AddTask(registeredTechSlot.GetTask());
        techSlotValidation.SetActive(false);
    }

    public void CancelTechnologyBuy()
    {
        techSlotValidation.SetActive(false);
    }
}
