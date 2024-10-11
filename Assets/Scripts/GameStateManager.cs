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

    private GameState gameState = GameState.PREPARING;

    public GameState GetGameState()
    {
        return gameState;
    }

    public void SetGameState(GameState newGameState)
    {
        gameState = newGameState;
    }

}
