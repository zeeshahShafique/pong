using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    [SerializeField] private Camera Camera;

    private float _heightUnit;

    private float _widthUnit;

    [SerializeField] private GameObject[] Boundaries;
    
    //private void 

    private void OnEnable()
    {
        _heightUnit = Camera.orthographicSize;
        _widthUnit = Camera.aspect * _heightUnit;
        
        Debug.Log("YUnit Size: " + _heightUnit + "\tXUnit Size: " + _widthUnit);
        
        SetBoundaries();
    }

    void SetBoundaries()
    {
        Boundaries[0].transform.position = new Vector3(0, _heightUnit);
        Boundaries[0].transform.localScale = new Vector3(_widthUnit*2, 0.5f);
        
        Boundaries[1].transform.position = new Vector3(0, -_heightUnit);
        Boundaries[1].transform.localScale = new Vector3(_widthUnit * 2, 0.5f);
        
        Boundaries[2].transform.position = new Vector3(_widthUnit, 0);
        Boundaries[2].transform.localScale = new Vector3(0.5f, _heightUnit * 2);

        Boundaries[3].transform.position = new Vector3(-_widthUnit, 0);
        Boundaries[3].transform.localScale = new Vector3(0.5f, _heightUnit * 2);
    }
}
