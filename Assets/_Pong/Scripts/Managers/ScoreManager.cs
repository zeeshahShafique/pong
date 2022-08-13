using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int _playerScore;
    [SerializeField] private int _aiScore;

    [SerializeField] private TextMeshProUGUI _playerScoreText;
    [SerializeField] private TextMeshProUGUI _aiScoreText;

    public int PlayerScore
    {
        get => _playerScore;
        set => _playerScore = value;
    }

    public int AIScore
    {
        get => _aiScore;
        set => _aiScore = value;
    }

    private void SetPlayerScoreText()
    {
        _playerScoreText.SetText(_playerScore.ToString());
    }
    
    private void SetAIScoreText()
    {
        _aiScoreText.SetText(_aiScore.ToString());
    }
}
