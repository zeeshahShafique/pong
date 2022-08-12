using System;
using _Pong.Scripts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
public class TapToStartScreen : MonoBehaviour, IPointerDownHandler
{
    private ISpawnBall _ballSpawner;

    private void OnEnable()
    {
        _ballSpawner = FindObjectOfType<BallSpawner>().GetComponent<ISpawnBall>();
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        _ballSpawner.SpawnBall();
    }
    
}
