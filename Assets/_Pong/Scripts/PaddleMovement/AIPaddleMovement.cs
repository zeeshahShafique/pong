using UnityEngine;

public class AIPaddleMovement : PaddleMovement
{
    [SerializeField] private Rigidbody2D _BallRigidbody2D;

    public override void MovePaddle()
    {
        if (_BallRigidbody2D.velocity.y > 0f && _BallRigidbody2D.transform.position.y > 0)
        {
            if (_BallRigidbody2D.transform.position.x > transform.position.x)
            {
                _Movement = Vector2.right;
            }
            else if (_BallRigidbody2D.transform.position.x < transform.position.x)
            {
                _Movement = Vector2.left;
            }
        }
        else
        {
            _Movement = Vector2.zero;
        }
    }
}
