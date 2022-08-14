using UnityEngine;

public class AIPaddleMovement : PaddleMovement
{
    [SerializeField] private Rigidbody2D _BallRigidbody2D;

    protected override void MovePaddle()
    {
        if (_BallRigidbody2D.velocity.y > 0f && _BallRigidbody2D.transform.position.y > 0)
        {
            if (_BallRigidbody2D.transform.position.x > transform.position.x)
            {
                _Movement = _BallRigidbody2D.transform.position;
            }
            else if (_BallRigidbody2D.transform.position.x < transform.position.x)
            {
                _Movement = _BallRigidbody2D.transform.position;
            }
        }
        _Movement.y = transform.localPosition.y;
    }

    protected override void SetPaddleMovement()
    {
        // _Rigidbody2D.velocity = _Movement * Speed;
        // ClampTransform();
        
        float distance = Vector2.Distance(transform.localPosition, _Movement);
        transform.localPosition = Vector3.Lerp(transform.localPosition,
            _Movement,
            Time.deltaTime * Speed * distance);
        ClampTransform();
    }
}
