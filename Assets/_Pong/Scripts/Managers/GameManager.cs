using UnityEngine;
using Application = UnityEngine.Device.Application;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SceneSpawner _sceneSpawner;
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private BallSpawner _ballSpawner;

    public delegate void AIWon();
    public static event AIWon OnAIWon;

    public delegate void PlayerWon();
    public static event PlayerWon OnPlayerWon;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        _sceneSpawner = GetComponentInChildren<SceneSpawner>();
        _scoreManager = GetComponentInChildren<ScoreManager>();
        _ballSpawner = GetComponentInChildren<BallSpawner>();
    }

    private void Start()
    {
        _sceneSpawner.enabled = true;
        _scoreManager.enabled = true;
        _ballSpawner.enabled = true;
    }

    private void Update()
    {
        if (_scoreManager.GetPlayerScore() > 5)
        {
            OnPlayerWon();
            _ballSpawner.enabled = false;
        }
        else if (_scoreManager.GetAIScore() > 5)
        {
            OnAIWon();
            _ballSpawner.enabled = false;
        }
    }
}
