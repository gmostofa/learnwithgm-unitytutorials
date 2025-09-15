using UnityEngine;

public class EnumTutorial : MonoBehaviour
{
    public enum PlayerState
    {
        Idle,
        Walking,
        Jumping
    }
    
    public PlayerState currentState;
    
    
    void Update()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                Debug.Log("Player is standing still.");
                break;
            case PlayerState.Walking:
                Debug.Log("Player is moving.");
                break;
            case PlayerState.Jumping:
                Debug.Log("Player is in the air.");
                break;
        }
    }
}
