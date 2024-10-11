using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject startDay;
    GameStateManager gameStateManager;
    TimelineManager timelineManager;

    private void Awake()
    {
        gameStateManager = GetComponent<GameStateManager>();
        timelineManager = GetComponent<TimelineManager>();
    }
    public void SwitchToTimeline()
    {
        timeline.SetActive(false);
        startDay.SetActive(true);
        gameStateManager.SetGameState(GameStateManager.GameState.TIMELINE);
        timelineManager.PreStartTimeline();
    }
}
