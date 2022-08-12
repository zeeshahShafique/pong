using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallSpawner : MonoBehaviour
{
    private Rigidbody2D rd2;
    [SerializeField] private GameObject _Ball;

    [SerializeField] private int _RangeMin;
    [SerializeField] private int _RangeMax;

    void OnEnable()
    {
        rd2 = _Ball.GetComponent<Rigidbody2D>();
        SpawnBall();
    }

    private void OnDisable()
    {
        _Ball.transform.position = Vector3.zero;
    }

    void SpawnBall()
    {
        int side = Random.Range(0, 2);
        if (side < 1)
        {
            side = -1;
        }

        int directionY = Random.Range(_RangeMin, _RangeMax);
        rd2.AddForce(new Vector2(20 * side, directionY * side));
    }
}
