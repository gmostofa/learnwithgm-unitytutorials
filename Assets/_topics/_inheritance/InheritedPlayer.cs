using UnityEngine;

public class InheritedPlayer : Character
{
    public float jumpForce = 10f;

    private void Start()
    {
        characterName = "Hero";
        health = 1000f;
        moveSpeed = 50f;
    }

    public override void Move()
    {
        Debug.Log(characterName + " is sprinting at speed: " + (moveSpeed * 1.5f));
    }

    public void Jump()
    {
        Debug.Log(characterName + " jumps with force: " + jumpForce);
    }
}
