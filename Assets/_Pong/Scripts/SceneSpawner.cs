using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    [SerializeField] private Camera _Camera;

    private float _heightUnit;

    public static float WidthUnit;

    [SerializeField] private GameObject[] _Boundaries;
    [SerializeField] private GameObject[] _Paddles;
    
    //private void 

    private void OnEnable()
    {
        _heightUnit = _Camera.orthographicSize;
        WidthUnit = _Camera.aspect * _heightUnit;
        
        SetBoundaries();
        SetPaddles();
    }

    void SetBoundaries()
    {
        _Boundaries[0].transform.position = new Vector3(0, _heightUnit);
        _Boundaries[0].transform.localScale = new Vector3(WidthUnit*2, 0.5f);
        
        _Boundaries[1].transform.position = new Vector3(0, -_heightUnit);
        _Boundaries[1].transform.localScale = new Vector3(WidthUnit * 2, 0.5f);
        
        _Boundaries[2].transform.position = new Vector3(WidthUnit, 0);
        _Boundaries[2].transform.localScale = new Vector3(0.5f, _heightUnit * 2);

        _Boundaries[3].transform.position = new Vector3(-WidthUnit, 0);
        _Boundaries[3].transform.localScale = new Vector3(0.5f, _heightUnit * 2);
    }

    void SetPaddles()
    {
        _Paddles[1].transform.position = new Vector3(0, _heightUnit - 1);
        
        _Paddles[0].transform.position = new Vector3(0, -_heightUnit + 1);
    }
}
