using System;
using UnityEngine;

public class GoalPost : MonoBehaviour
{
    public delegate void AIScored();
    public static event AIScored OnAIScored;

    public delegate void PlayerScored();
    public static event PlayerScored OnPlayerScored;
    
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            if (transform.position.y > 0)
            {
                OnPlayerScored();
            }
            else if (transform.position.y < 0)
            {
                OnAIScored();
            } 
        }
    }
}
