using UnityEngine;
/*
 * Meaningful Naming
 * Use Proper Access Modifiers
 * Avoid Magic Numbers
 * Single Responsibility Principle
 * Use Proper Access Modifiers
 * Consistent Project Organization
 * Use Comments Wisely, Make your code Descriptive
 * Error Handling in Unity
 * Write Modular & Reusable Code
 */

// ❌ Bad Example
public class scr1 : MonoBehaviour
{
    public GameObject src1;
    void Update()
    {
        // Movement, Jumping, Shooting, Input Handling all in one
        transform.Translate(Vector3.forward * 5f);
    }
}

// ✅ Good Example
public class PlayerController : MonoBehaviour
{
    private GameObject enemyPrefab;
    [SerializeField] private float moveSpeed = 5f;
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        HandleMovement();
        HandleJump();
        HandleShooting();
    }
    private void HandleShooting() { }
    private void HandleJump() { }
    private void HandleMovement() { }
}