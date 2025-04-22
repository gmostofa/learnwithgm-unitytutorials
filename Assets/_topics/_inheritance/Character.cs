using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public float health = 100f;
    public float moveSpeed = 5f;

    public virtual void Move()
    {
        Debug.Log(characterName + " is moving at speed: " + moveSpeed);
    }

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(characterName + " took " + damage + " damage. Health: " + health);
    }
}