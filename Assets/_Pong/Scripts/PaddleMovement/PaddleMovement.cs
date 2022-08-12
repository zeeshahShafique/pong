using UnityEngine;

public abstract class PaddleMovement : MonoBehaviour
{
    protected Rigidbody2D _RigidBody2D;
    public float Speed;
    protected Vector2 _Movement;

    protected float _LeftClampPos;
    protected float _RightClampPos;
    
    private void Start()
    {
        _LeftClampPos = -SceneSpawner.WidthUnit + (transform.localScale.x / 1.5f);
        _RightClampPos = SceneSpawner.WidthUnit - (transform.localScale.x / 1.5f);
    }

    public abstract void MovePaddle();

}
