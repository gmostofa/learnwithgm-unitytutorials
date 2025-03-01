using UnityEngine;

public class Player 
{
   public string playerName;
   public int playerScore;
   public int playerHealth;
   public bool isPlayerDead;

   public Player(string playerName, int playerScore, int playerHealth)
   {
      this.playerName = playerName;
      this.playerScore = playerScore;
      this.playerHealth = playerHealth;
   }

   public void PrintPlayerName()
   {
      Debug.Log("Player: " + playerName);
   }

   public void PrintPlayerScore()
   {
      Debug.Log("Player SCore: " + playerScore);
   }
}
