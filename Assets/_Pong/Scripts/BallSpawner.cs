using System;
using _Pong.Scripts;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallSpawner : MonoBehaviour, ISpawnBall
{
    private Rigidbody2D _rd2;
    [SerializeField] private GameObject _Ball;

    [SerializeField] private int _RangeMin;
    [SerializeField] private int _RangeMax;

    void OnEnable()
    {
        _rd2 = _Ball.GetComponent<Rigidbody2D>();
        // SpawnBall();
    }

    private void OnDisable()
    {
        if (_Ball)
            _Ball.transform.position = Vector3.zero;
    }

    public virtual void SpawnBall()
    {
        int side = Random.Range(0, 2);
        if (side < 1)
        {
            side = -1;
        }

        int directionY = Random.Range(_RangeMin, _RangeMax);
        _rd2.AddForce(new Vector2(20 * side, directionY * side));
    }
}
