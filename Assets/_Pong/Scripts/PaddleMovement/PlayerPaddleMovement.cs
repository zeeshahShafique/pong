using UnityEngine;

public class PlayerPaddleMovement : PaddleMovement
{
    protected override void MovePaddle()
    {
        _Movement.x = InputController.InputPos.x;
        _Movement.y = transform.localPosition.y;
    }

    protected override void SetPaddleMovement()
    {
        float distance = Vector2.Distance(transform.localPosition, _Movement);
        transform.localPosition = Vector3.Lerp(transform.localPosition,
            _Movement,
            Time.deltaTime * 2 + distance);
        ClampTransform();
    }
}
