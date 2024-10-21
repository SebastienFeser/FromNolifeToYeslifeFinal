using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        PREPARING,
        TIMELINE,
        END_DAY
    }

    public enum TimeDay
    {
        H9,
        H12,
        H15,
        H18,
        H21
    }

    private GameState gameState = GameState.PREPARING;
    private TimeDay timeDay = TimeDay.H9;

    public TimeDay GetTimeDay()
    {
        return timeDay;
    }

    public void SetTimeDay(TimeDay newTimeDay)
    {
        timeDay = newTimeDay;
    }

    public GameState GetGameState()
    {
        return gameState;
    }

    public void SetGameState(GameState newGameState)
    {
        gameState = newGameState;
    }

}
