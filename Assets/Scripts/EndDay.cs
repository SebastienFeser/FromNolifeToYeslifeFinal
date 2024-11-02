using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDay : MonoBehaviour
{
    [SerializeField] TaskSlotsManager taskSlotsManager;
    int physicalCondition = 0;
    int motivation = 0;
    int societalIntegration = 0;
    int sociable = 0;
    int money = 0;
    int mentalHealth = 0;
    int ideas = 0;

    [SerializeField] TextMeshProUGUI physicalConditionText;
    [SerializeField] TextMeshProUGUI motivationText;
    [SerializeField] TextMeshProUGUI societalIntegrationText;
    [SerializeField] TextMeshProUGUI sociableText;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI mentalHealthText;
    [SerializeField] TextMeshProUGUI ideasText;

    private void Awake()
    {
    }

    public void LoadEnd()
    {
        LoadEachTask();
        ApplyDailyCost();
        DisplayText();
    }
    private void LoadEachTask()
    {
        LoadTaskOutputs(taskSlotsManager.GetTaskAtTime(TaskSlotsManager.TimelineSlots.H9));
        LoadTaskOutputs(taskSlotsManager.GetTaskAtTime(TaskSlotsManager.TimelineSlots.H12));
        LoadTaskOutputs(taskSlotsManager.GetTaskAtTime(TaskSlotsManager.TimelineSlots.H15));
        LoadTaskOutputs(taskSlotsManager.GetTaskAtTime(TaskSlotsManager.TimelineSlots.H18));
        LoadTaskOutputs(taskSlotsManager.GetTaskAtTime(TaskSlotsManager.TimelineSlots.H21));
    }

    private void LoadTaskOutputs(Task task)
    {
        if (task != null)
        {
            physicalCondition += task.physicalConditionOutput;
            motivation += task.motivationOutput;
            societalIntegration += task.societalIntegrationOutput;
            sociable += task.sociableOutput;
            money += task.moneyOutput;
            mentalHealth += task.mentalHealthOutput;
            ideas += task.ideasOutput;
        }
    }

    private void ApplyDailyCost()
    {

    }

    private void DisplayText()
    {
        if(physicalCondition >= 0)
        {
            physicalConditionText.text = "+" + physicalCondition + " Physical Condition";
        }
        else
        {
            physicalConditionText.text = physicalCondition + " Physical Condition";
        }
        if (motivation >= 0)
        {
            motivationText.text = "+" + motivation + " Motivation";
        }
        else
        {
            motivationText.text = motivation + " Motivation";
        }
        if (societalIntegration >= 0)
        {
            societalIntegrationText.text = "+" + societalIntegration + " Societal Integration";
        }
        else
        {
            societalIntegrationText.text = societalIntegration + " Societal Integration";
        }
        if (sociable >= 0)
        {
            sociableText.text = "+" + sociable + " Sociable";
        }
        else
        {
            sociableText.text = sociable + " Sociable";
        }
        if (money >= 0)
        {
            moneyText.text = "+" + money + " Money";
        }
        else
        {
            moneyText.text = money + " Money";
        }
        if (mentalHealth >= 0)
        {
            mentalHealthText.text = "+" + mentalHealth + " Mental Health";
        }
        else
        {
            mentalHealthText.text = mentalHealth + " Mental Health";
        }
        if (ideas >= 0)
        {
            ideasText.text = "+" + ideas + " Ideas";
        }
        else
        {
            ideasText.text = ideas + " Ideas";
        }
    }

}
