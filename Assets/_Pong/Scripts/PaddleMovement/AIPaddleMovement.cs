using UnityEngine;

public class AIPaddleMovement : PaddleMovement
{
    [SerializeField] private GameObject _ball;

    public override void MovePaddle()
    {
        if (_ball.transform.position.y > 0f)
        {
            if (_ball.transform.position.x > transform.position.x)
            {
                _Movement = Vector2.right;
            }
            else if (_ball.transform.position.x < transform.position.x)
            {
                _Movement = Vector2.left;
            }
        }
    }
}
