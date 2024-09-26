using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TechSlot : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] ScriptableObject task;
    [SerializeField] List<TechSlot> nextUnlockedTechs;
    [SerializeField] GameObject link;
    List<GameObject> links;

    private void Start()
    {
        CreateLinks();
    }

    void CreateLinks()
    {
        foreach(TechSlot element in nextUnlockedTechs)
        {
            GameObject newLink = Instantiate(link, transform.parent);
            newLink.transform.SetAsFirstSibling();
            newLink.transform.position = (element.transform.position + transform.position) / 2;
            RectTransform rectTransform = newLink.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, Vector2.Distance(transform.position, element.transform.position));
            newLink.transform.eulerAngles = new Vector3(0,0,(180/Mathf.PI)*(Mathf.Atan2(Mathf.Abs(element.transform.position.x - transform.position.x),Mathf.Abs(element.transform.position.y - transform.position.y))));
            links.Add(newLink);
        }
    }
}
