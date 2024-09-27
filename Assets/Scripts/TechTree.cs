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
    // Start is called before the first frame update
    void Awake()
    {
        startPosition = techTreeTransform.position;
    }

    // Update is called once per frame
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
}
