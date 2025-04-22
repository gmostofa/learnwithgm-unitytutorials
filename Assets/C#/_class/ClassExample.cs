using System;
using UnityEngine;

public class ClassExample : MonoBehaviour
{
    private void Start()
    {
        Player myPlayer = new Player("John", 120, 100);
        myPlayer.PrintPlayerName();
        myPlayer.PrintPlayerScore();
        
        Player myPlayer2 = new Player("Stone", 20, 100);
        myPlayer2.PrintPlayerName();
        myPlayer2.PrintPlayerScore();
    }
}
