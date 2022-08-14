using UnityEngine;

public class InputController : MonoBehaviour
{
    public static Vector2 InputPos;
    public static bool Enabled = false;

    private Camera _mainCam;

    private void Start()
    {
        _mainCam = Camera.main;
    }

    private void Update()
    {
        // Debug.Log(Input.touchCount);
        if (!Enabled) return;

        if (Input.touchCount<=0) return;

        InputPos = Input.GetTouch(0).position;
        InputPos = _mainCam.ScreenToWorldPoint(InputPos);
    }
}
