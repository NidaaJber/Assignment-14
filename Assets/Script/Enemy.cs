using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

    void Start()
    {
        
    }
   
    public Enemy(string enemyName, int initialHealth) : base(enemyName, initialHealth)
    {
    }

    
    public void Attack(Character target, int damage)
    {
        target.Health -= damage;
        Debug.Log(Name + " attacked " + target.Name + "! " + target.Name + "'s health: " + target.Health);
    }

     void Update()
    {
        
    }
}
