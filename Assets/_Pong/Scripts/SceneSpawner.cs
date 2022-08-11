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
    }
}
