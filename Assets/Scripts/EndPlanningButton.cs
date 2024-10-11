using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlanningButton : MonoBehaviour
{
    [SerializeField] GameObject validateButton;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void EndButtonClick()
    {
        validateButton.SetActive(true);
    }

    public void EndButtonValidate()
    {
        gameManager.SwitchToTimeline();
        validateButton.SetActive(false);
    }

    public void EndButtonCancel()
    {
        validateButton.SetActive(false);
    }
}
