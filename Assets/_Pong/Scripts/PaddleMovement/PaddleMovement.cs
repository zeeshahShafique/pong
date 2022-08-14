using System;
using UnityEngine;

public abstract class PaddleMovement : MonoBehaviour
{
    protected Rigidbody2D _Rigidbody2D;
    public float Speed;
    protected Vector2 _Movement;

    protected float _LeftClampPos;
    protected float _RightClampPos;

    protected Vector3 _Position;



    private void OnEnable()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void Start()
    {
        _LeftClampPos = -SceneSpawner.WidthUnit + (transform.localScale.x / 1.5f);
        _RightClampPos = SceneSpawner.WidthUnit - (transform.localScale.x / 1.5f);
    }

    private void Update()
    {
        MovePaddle();
        SetPaddleMovement();
    }

    private void FixedUpdate()
    {
        
    }

    protected abstract void MovePaddle();

    protected abstract void SetPaddleMovement();

    protected void ClampTransform()
    {
        var clampX = Math.Clamp(transform.position.x, _LeftClampPos, _RightClampPos);

        _Position = transform.position;
        _Position.x = clampX;
        transform.position = _Position;
    }

}
