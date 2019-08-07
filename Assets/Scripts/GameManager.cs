using UnityEngine;
using System.Collections;

// Game States
// for now we are only using these two
public enum GameState { MAIN, SUN, EARTH }

public delegate void OnStateChangeHandler();

public class GameManager
{
    protected GameManager() { }
    private static GameManager instance = null;
    public event OnStateChangeHandler OnStateChange;
    public GameState gameState { get; private set; }
    public GameState previousState { get; private set; }

    public static GameManager Instance
    {
        get
        {
            if (GameManager.instance == null)
            {
                //GameManager.DontDestroyOnLoad(GameManager.instance);
                GameManager.instance = new GameManager();
            }
            return GameManager.instance;
        }

    }

    public void SetGameState(GameState state)
    {
        previousState = gameState;
        this.gameState = state;
        OnStateChange();
    }

    public GameState GetPreviousState()
    {
        return previousState;
    }

    public void OnApplicationQuit()
    {
        GameManager.instance = null;
    }

}