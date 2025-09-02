using UnityEngine;

public class Player 
{
    string playerName; // private as default
    int playerScore;
    int playerHealth;
    bool isPlayerDead;
    protected int thisIsProtectedVariable;
    

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
