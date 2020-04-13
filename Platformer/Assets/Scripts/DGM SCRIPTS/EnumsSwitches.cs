using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{
    public UnityEvent idleEvent, walkingEvent, runningEvent, jumpingEvent;
    public UnityEvent startingEvent, playingEvent, pausingEvent, endingEvent;

    public enum GameStates
    {
        Starting,
        Playing,
        Pausing,
        Ending
    }

    public GameStates currentGameState;

    public enum PlayerStates
    {
        Idle,
        Walking,
        Running,
        Jumping
    }
    
    public PlayerStates currentPlayerState;

    // Start is called before the first frame update
    public void ChangeStateToStarting()
    {
        currentGameState = GameStates.Starting;
    }

    public void ChangeStateToPlaying()
    {
        currentGameState = GameStates.Playing;
    }

    public void ChangeStateToPausing()
    {
        currentGameState = GameStates.Pausing;
    }

    public void ChangeStateToEnding()
    {
        currentGameState = GameStates.Ending;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke();
                break;
            case PlayerStates.Walking:
                walkingEvent.Invoke();
                break;
            case PlayerStates.Running:
                runningEvent.Invoke();
                break;
            case PlayerStates.Jumping:
                jumpingEvent.Invoke();
                break;
            default:
                print("I am none of the above!");
                break;
        }

        switch (currentGameState)
        {
            case GameStates.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.Pausing:
                pausingEvent.Invoke();
                break;
            case GameStates.Ending:
                endingEvent.Invoke();
                break;
            default:
                print("I am none of the above!");
                break;
        }
    }
}
