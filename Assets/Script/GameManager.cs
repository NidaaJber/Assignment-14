using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Declare a player and an enemy
    private Player player;
    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        // Create the player and enemy characters
        player = new Player("Subhi", 100);
        enemy = new Enemy("Zarifeh", 100);

        // Print their names and health
        Debug.Log("Player: " + player.Name + " Health: " + player.Health);
        Debug.Log("Enemy: " + enemy.Name + " Health: " + enemy.Health);

        // Test the Heal() method on the player
        player.Heal(20);

        // Test the Attack() method on the enemy
        enemy.Attack(player, 30);
    }
}
