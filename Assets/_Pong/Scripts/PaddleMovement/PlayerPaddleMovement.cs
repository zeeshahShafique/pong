public class PlayerPaddleMovement : PaddleMovement
{
    public override void MovePaddle()
    {
        _Movement.x = -InputController.Input.x;
        _Movement.y = 0;
    }
}
