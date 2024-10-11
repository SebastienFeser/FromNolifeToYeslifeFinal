using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    GameStateManager gameStateManager;

    private void Awake()
    {
        gameStateManager = GetComponent<GameStateManager>();
    }
    public void SwitchToTimeline()
    {
        timeline.SetActive(false);
        gameStateManager.SetGameState(GameStateManager.GameState.TIMELINE);
    }
}
