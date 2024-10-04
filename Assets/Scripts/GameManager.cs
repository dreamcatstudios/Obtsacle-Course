using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public delegate void GameEvent();
    public static event GameEvent OnLifeLost;
    public static event GameEvent OnGameWon;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoseLife()
    {
        OnLifeLost?.Invoke();
    }

    public void WinGame()
    {
        OnGameWon?.Invoke();
    }
}
