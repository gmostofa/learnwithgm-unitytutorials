using UnityEngine;

public class InheritedEnemy : Character
{
    public float attackPower = 15f;

    private void Start()
    {
        characterName = "Goblin";
    }

    public override void Move()
    {
        Debug.Log(characterName + " is chasing the player at speed: " + moveSpeed);
    }

    public void Attack(InheritedPlayer player)
    {
        Debug.Log(characterName + " attacks " + player.characterName + " with power: " + attackPower);
        player.TakeDamage(attackPower);
    }
}
