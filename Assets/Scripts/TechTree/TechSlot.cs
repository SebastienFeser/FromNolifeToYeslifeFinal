using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TechSlot : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] Task task;
    [SerializeField] List<TechSlot> nextUnlockedTechs;
    [SerializeField] GameObject link;
    [SerializeField] Sprite lockedSprite;
    [SerializeField] Sprite unlockedSprite;
    [SerializeField] Sprite boughtSprite;
    [SerializeField] TechTree techTree;
    List<GameObject> links = new List<GameObject>();
    Canvas canvas;
    bool isUnlocked = false;
    bool isBought = false;

    private void Awake()
    {
        techTree = GetComponentInParent<TechTree>();
        isUnlocked = false;
        isBought = false;
        canvas = transform.root.GetComponent<Canvas>();
        SetTechnology();
        CreateLinks();
    }

    void CreateLinks()
    {
        foreach(TechSlot element in nextUnlockedTechs)
        {
            GameObject newLink = Instantiate(link, transform.parent);
            RectTransform rectTransformLink = newLink.GetComponent<RectTransform>();
            RectTransform rectTransformThis = GetComponent<RectTransform>();
            RectTransform rectTransformElement = element.GetComponent<RectTransform>();
            newLink.transform.SetAsFirstSibling();
            newLink.transform.position = (element.transform.position + transform.position) / 2;
            rectTransformLink.sizeDelta = new Vector2(rectTransformLink.sizeDelta.x, Vector2.Distance(rectTransformThis.position, rectTransformElement.position)/canvas.scaleFactor);
            newLink.transform.eulerAngles = new Vector3(0,0,-(180/Mathf.PI)*(Mathf.Atan2(element.transform.position.x - transform.position.x,element.transform.position.y - transform.position.y)));
            links.Add(newLink);
        }
    }

    void SetTechnology()
    {
        text.text = task.name;
    }

    public void UnlockTechnology()
    {
        isUnlocked = true;
        GetComponent<Image>().sprite = unlockedSprite;
    }

    public void StartBuyTechnology()
    {
        if(isBought)
        {

        }
        else if (!isUnlocked)
        {

        }
        else
        {
            techTree.BuyTechnology(this);
        }
    }
    public void BuyTechnology()
    {
        GetComponent<Image>().sprite = boughtSprite;
        foreach(TechSlot element in nextUnlockedTechs)
        {
            element.UnlockTechnology();
        }
        isBought = true;
    }

    public Task GetTask()
    {
        return task;
    }
}
