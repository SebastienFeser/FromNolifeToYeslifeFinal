using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject startDay;
    [SerializeField] GameObject endDayGameObject;
    GameStateManager gameStateManager;
    TimelineManager timelineManager;
    EndDay endDay;

    private void Awake()
    {
        gameStateManager = GetComponent<GameStateManager>();
        timelineManager = GetComponent<TimelineManager>();
        endDay = endDayGameObject.GetComponent<EndDay>();
    }
    public void SwitchToTimeline()
    {
        timeline.SetActive(false);
        startDay.SetActive(true);
        gameStateManager.SetGameState(GameStateManager.GameState.TIMELINE);
        timelineManager.PreStartTimeline();
    }

    public void SwitchToEnd()
    {
        endDayGameObject.SetActive(true);
        endDay.LoadEnd();
    }
}
