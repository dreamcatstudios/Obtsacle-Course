using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI messageText;

    [SerializeField]
    private int initialLives = 5;

    private int currentLives;
    private bool hasWon;

    private void OnEnable()
    {
        GameManager.OnLifeLost += DecreaseLives;
        GameManager.OnGameWon += SetWinCondition;
    }

    private void OnDisable()
    {
        GameManager.OnLifeLost -= DecreaseLives;
        GameManager.OnGameWon -= SetWinCondition;
    }

    private void Start()
    {
        currentLives = initialLives;
        UpdateUI();
    }

    private void DecreaseLives()
    {
        currentLives--;
        UpdateUI();
    }

    private void SetWinCondition()
    {
        if (currentLives > 0)
        {
            hasWon = true;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        if (hasWon)
        {
            messageText.text = "You Won :)";
        }
        else if (currentLives > 0)
        {
            messageText.text = $"Your Current Life: {currentLives}";
        }
        else
        {
            messageText.text = "Game Over!";
        }
    }
}
