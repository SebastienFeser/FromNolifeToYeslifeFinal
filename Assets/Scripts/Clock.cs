using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{

    [SerializeField] float timeMultiplier;
    [SerializeField] TextMeshProUGUI text;
    GameStateManager gameStateManager;
    GameManager gameManager;
    float timeSpeedMultiplier;
    int hoursDisplayed;
    int minutesDisplayed;
    float minutes;

    private void Awake()
    {
        gameStateManager = FindObjectOfType<GameStateManager>();
        gameManager = FindObjectOfType<GameManager>();
    }


    public void StartTime()
    {
        hoursDisplayed = 9;
        minutesDisplayed = 0;
        minutes = 0;
        text.text = hoursDisplayed.ToString("D2") + ":" + minutesDisplayed.ToString("D2");
    }

    public void X0TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 0;
    }

    public void X1TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 1;
    }

    public void X2TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 2;
    }

    public void X3TimeSpeedMultiplier()
    {
        timeSpeedMultiplier = 4;
    }

    public void UpdateTimer()
    {
        text.text = hoursDisplayed.ToString("D2") + ":" + minutesDisplayed.ToString("D2");
        minutes += Time.deltaTime * timeMultiplier * timeSpeedMultiplier;
        if(minutes > 1f )
        {
            if(minutesDisplayed >= 59)
            {
                hoursDisplayed++;
                minutesDisplayed = 0;
            }
            else
            {
                minutesDisplayed++;
            }
            minutes -= 1f;
        }

        switch(gameStateManager.GetTimeDay())
        {
            case GameStateManager.TimeDay.H9:
                if(hoursDisplayed >= 12)
                {
                    gameStateManager.SetTimeDay(GameStateManager.TimeDay.H12);
                }
                break;
            case GameStateManager.TimeDay.H12:
                if (hoursDisplayed >= 15)
                {
                    gameStateManager.SetTimeDay(GameStateManager.TimeDay.H15);
                }
                break;
            case GameStateManager.TimeDay.H15:
                if (hoursDisplayed >= 18)
                {
                    gameStateManager.SetTimeDay(GameStateManager.TimeDay.H18);
                }
                break;
            case GameStateManager.TimeDay.H18:
                if (hoursDisplayed >= 21)
                {
                    gameStateManager.SetTimeDay(GameStateManager.TimeDay.H21);
                }
                break;
            case GameStateManager.TimeDay.H21:
                if (hoursDisplayed >= 24)
                {
                    gameStateManager.SetGameState(GameStateManager.GameState.END_DAY);
                    gameManager.SwitchToEnd();
                    X0TimeSpeedMultiplier();
                    hoursDisplayed = 0;
                }
                break;
        }
    }
}
