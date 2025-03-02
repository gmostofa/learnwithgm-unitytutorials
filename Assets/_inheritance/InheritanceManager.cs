using UnityEngine;

public class InheritanceManager : MonoBehaviour
{
    public InheritedPlayer player;
    public InheritedEnemy enemy;

    private void Start()
    {
        player.Move();
        player.Jump();

        enemy.Move();
        enemy.Attack(player);
    }
}
