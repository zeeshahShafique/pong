using UnityEngine;
using Application = UnityEngine.Device.Application;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SceneSpawner _SceneSpawner;
    [SerializeField] private ScoreManager _ScoreManager;
    [SerializeField] private BallSpawner _BallSpawner;

    [SerializeField] private int _WinningScore;

    public delegate void AIWon();
    public static event AIWon OnAIWon;

    public delegate void PlayerWon();
    public static event PlayerWon OnPlayerWon;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        _SceneSpawner = GetComponentInChildren<SceneSpawner>();
        _ScoreManager = GetComponentInChildren<ScoreManager>();
        _BallSpawner = GetComponentInChildren<BallSpawner>();
    }

    private void Start()
    {
        _SceneSpawner.enabled = true;
        _ScoreManager.enabled = true;
        _BallSpawner.enabled = true;
    }

    private void Update()
    {
        if (_ScoreManager.GetPlayerScore() >= _WinningScore)
        {
            OnPlayerWon();
        }
        else if (_ScoreManager.GetAIScore() >= _WinningScore)
        {
            OnAIWon();
        }
    }
}
