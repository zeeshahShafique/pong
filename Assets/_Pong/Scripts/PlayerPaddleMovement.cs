using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerPaddleMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    
    public float _movementX;

    [SerializeField] private float _playerSpeed;
    private Vector2 _movement = Vector2.zero;

    private Vector3 _position;

    [SerializeField] private float _leftWall;
    [SerializeField] private float _rightWall;

    private void OnEnable()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _leftWall = -SceneSpawner.WidthUnit + (transform.localScale.x / 1.5f);
        _rightWall = SceneSpawner.WidthUnit - (transform.localScale.x / 1.5f);
    }

    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();

        _movementX = v.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _movement.x = _movementX;

        _rigidbody2D.velocity = _movement * _playerSpeed;

        var clampX = Math.Clamp(transform.position.x, _leftWall, _rightWall);

        _position.x = clampX;
        _position.y = transform.position.y;
        _position.z = transform.position.z;

        transform.position = _position;

    }
}
