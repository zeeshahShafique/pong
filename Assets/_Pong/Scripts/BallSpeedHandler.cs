using System;
using UnityEngine;

public class BallSpeedHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _SpeedFactor;

    private void OnEnable()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.CompareTag("Paddle"))
        {
            Debug.Log($"VelocityOld: {_rigidbody2D.velocity}");
            _rigidbody2D.velocity *= _SpeedFactor;
            Debug.Log($"VelocityNew: {_rigidbody2D.velocity}");

        }
    }
}
