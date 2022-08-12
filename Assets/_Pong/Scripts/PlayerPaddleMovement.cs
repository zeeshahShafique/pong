using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PlayerPaddleMovement : PaddleMovement
{
    private Vector3 _position;
    
    private void OnEnable()
    {
        _RigidBody2D = GetComponent<Rigidbody2D>();
    }
    

    void FixedUpdate()
    {
        MovePaddle();
    }

    public override void MovePaddle()
    {
        _Movement.x = -InputController.Input.x;
        _Movement.y = 0;
        
        _RigidBody2D.velocity = _Movement * Speed;
    
        var clampX = Math.Clamp(transform.position.x, _LeftClampPos, _RightClampPos);

        _position = transform.position;
        _position.x = clampX;
        transform.position = _position;
    }
}
