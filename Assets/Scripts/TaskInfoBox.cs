using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskInfoBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI descriptionText;

    [SerializeField] TextMeshProUGUI mentalHealthText;
    [SerializeField] TextMeshProUGUI ideasText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI motivationText;
    [SerializeField] TextMeshProUGUI socialText;
    [SerializeField] TextMeshProUGUI physicalConditionText;
    [SerializeField] TextMeshProUGUI societalIntegrationText;

    [SerializeField] GameObject mentalHealthGO;
    [SerializeField] GameObject ideasGO;
    [SerializeField] GameObject moneyGO;
    [SerializeField] GameObject motivationGO;
    [SerializeField] GameObject socialGO;
    [SerializeField] GameObject physicalConditionGO;
    [SerializeField] GameObject societalIntegrationGO;

    public void OpenTaskInfoBox(Task task)
    {
        gameObject.SetActive(true);
        titleText.text = task.name;
        descriptionText.text = task.description;

        if(task.mentalHealthOutput > 0)
        {
            mentalHealthGO.SetActive(true);
            mentalHealthText.text = "+" + task.mentalHealthOutput + " Mental Health";
        }
        else if(task.mentalHealthOutput < 0)
        {
            mentalHealthGO.SetActive(true);
            mentalHealthText.text = task.mentalHealthOutput + " Mental Health";
        }
        else
        {
            mentalHealthGO.SetActive(false);
        }

        if (task.ideasOutput > 0)
        {
            ideasGO.SetActive(true);
            ideasText.text = "+" + task.ideasOutput + " Ideas";
        }
        else if (task.ideasOutput < 0)
        {
            ideasGO.SetActive(true);
            ideasText.text = task.ideasOutput + " Ideas";
        }
        else
        {
            ideasGO.SetActive(false);
        }

        if (task.moneyOutput > 0)
        {
            moneyGO.SetActive(true);
            moneyText.text = "+" + task.moneyOutput + " Money";
        }
        else if (task.moneyOutput < 0)
        {
            moneyGO.SetActive(true);
            moneyText.text = task.moneyOutput + " Money";
        }
        else
        {
            moneyGO.SetActive(false);
        }

        if (task.motivationOutput > 0)
        {
            motivationGO.SetActive(true);
            motivationText.text = "+" + task.motivationOutput + " Motivation";
        }
        else if (task.motivationOutput < 0)
        {
            motivationGO.SetActive(true);
            motivationText.text = task.motivationOutput + " Motivation";
        }
        else
        {
            motivationGO.SetActive(false);
        }

        if (task.sociableOutput > 0)
        {
            socialGO.SetActive(true);
            socialText.text = "+" + task.sociableOutput + " Social";
        }
        else if (task.sociableOutput < 0)
        {
            socialGO.SetActive(true);
            socialText.text = task.sociableOutput + " Social";
        }
        else
        {
            socialGO.SetActive(false);
        }

        if (task.physicalConditionOutput > 0)
        {
            physicalConditionGO.SetActive(true);
            physicalConditionText.text = "+" + task.physicalConditionOutput + " Physical Condition";
        }
        else if (task.physicalConditionOutput < 0)
        {
            physicalConditionGO.SetActive(true);
            physicalConditionText.text = task.physicalConditionOutput + " Physical Condition";
        }
        else
        {
            physicalConditionGO.SetActive(false);
        }

        if (task.societalIntegrationOutput > 0)
        {
            societalIntegrationGO.SetActive(true);
            societalIntegrationText.text = "+" + task.societalIntegrationOutput + " Societal Integration";
        }
        else if (task.societalIntegrationOutput < 0)
        {
            societalIntegrationGO.SetActive(true);
            societalIntegrationText.text = task.societalIntegrationOutput + " Societal Integration";
        }
        else
        {
            societalIntegrationGO.SetActive(false);
        }
    }

    public void CloseTaskInfoBox()
    {
        gameObject.SetActive(false);
    }
}
