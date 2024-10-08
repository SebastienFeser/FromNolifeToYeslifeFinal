using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TechTree : MonoBehaviour
{
    [SerializeField] Transform techTreeTransform;
    Vector2 startPosition;
    Vector2 startScale;
    Vector2 offset;
    private Vector3 mouseOrigin;
    [SerializeField] TechSlot startSlot;
    TechSlot registeredTechSlot;
    [SerializeField] GameObject techSlotValidation;
    PlayerManager playerManager;

    void Awake()
    {
        startPosition = techTreeTransform.position;
        startScale = techTreeTransform.localScale;
        playerManager = FindObjectOfType<PlayerManager>();
    }
    private void Start()
    {
        startSlot.UnlockTechnology();
    }

    void Update()
    {
        MoveTechTree();
        ZoomTechTree();
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

    private void ZoomTechTree()
    {
        Vector3 techTreeScale = techTreeTransform.localScale;
        techTreeScale += new Vector3(Input.mouseScrollDelta.y * 0.1f, Input.mouseScrollDelta.y * 0.1f, 1f);

        if(techTreeScale.x < 0.1f)
        {
            techTreeScale = new Vector3(0.1f, 0.1f, 1f);
        }
        else if (techTreeScale.x > 3f)
        {
            techTreeScale = new Vector3(3f, 3f, 1f);
        }
        techTreeTransform.localScale = techTreeScale;
    }

    public void QuitTechTree()
    {
        techTreeTransform.position = startPosition;
        techTreeTransform.localScale = startScale;
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
        playerManager.AddTask(registeredTechSlot.GetTask());
        techSlotValidation.SetActive(false);
    }

    public void CancelTechnologyBuy()
    {
        techSlotValidation.SetActive(false);
    }
}
