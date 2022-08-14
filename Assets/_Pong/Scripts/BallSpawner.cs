using UnityEngine;
using Random = UnityEngine.Random;

public class BallSpawner : MonoBehaviour
{
    private Rigidbody2D _rd2;
    [SerializeField] private GameObject _Ball;
    [SerializeField] private float _SpawnSpeed;

    [SerializeField] private int _RangeMin;
    [SerializeField] private int _RangeMax;

    void OnEnable()
    {
        _rd2 = _Ball.GetComponent<Rigidbody2D>();
        ResetBall();
        TapToStartScreen.StartScreenTapped.AddListener(GoalScored);
        GoalPost.OnPlayerScored += GoalScored;
        GoalPost.OnAIScored += GoalScored;
        GameManager.OnPlayerWon += DisableBall;
        GameManager.OnAIWon += DisableBall;
    }

    private void OnDisable()
    {
        TapToStartScreen.StartScreenTapped.RemoveListener(GoalScored);
        GoalPost.OnPlayerScored -= GoalScored;
        GoalPost.OnAIScored -= GoalScored;
        GameManager.OnPlayerWon -= DisableBall;
        GameManager.OnAIWon -= DisableBall;
    }

    public void SpawnBall()
    {
        var side = Random.Range(0, 2);
        if (side < 1)
        {
            side = -1;
        }

        var directionY = Random.Range(_RangeMin, _RangeMax);
        var directionX = Random.Range(10, 70);
        var directionVector = new Vector2(directionX * side, directionY * side).normalized;
        _rd2.AddForce(directionVector * _SpawnSpeed);
    }

    private void ResetBall()
    {
        if (_Ball && _rd2)
        {
            _Ball.transform.position = Vector3.zero;
            _rd2.velocity = Vector2.zero; 
        }
    }

    private void GoalScored()
    {
        Invoke(nameof(ResetBall), 1f);
        Invoke(nameof(SpawnBall), 1f);
    }

    private void DisableBall()
    {
        _Ball.SetActive(false);
    }
}
