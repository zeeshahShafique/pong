using System;
using Newtonsoft.Json.Bson;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int _playerScore;
    [SerializeField] private int _aiScore;

    [SerializeField] private TextMeshProUGUI _playerScoreText;
    [SerializeField] private TextMeshProUGUI _aiScoreText;

    private void OnEnable()
    {
        GoalPost.OnPlayerScored += PlayerScored;
        GoalPost.OnAIScored += AIScored;
    }
    
    private void OnDisable()
    {
        GoalPost.OnPlayerScored -= PlayerScored;
        GoalPost.OnAIScored -= AIScored;
    }

    private void PlayerScored()
    {
        _playerScore++;
        SetPlayerScoreText();
    }
    
    private void AIScored()
    {
        _aiScore++;
        SetAIScoreText();
    }

    private void SetPlayerScoreText()
    {
        _playerScoreText.SetText(_playerScore.ToString());
    }
    
    private void SetAIScoreText()
    {
        _aiScoreText.SetText(_aiScore.ToString());
    }

    public int GetPlayerScore()
    {
        return _playerScore;
    }

    public int GetAIScore()
    {
        return _aiScore;
    }
}
