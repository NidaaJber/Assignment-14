using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{

    void Start()
    {
        
    }
   
    public Player(string playerName, int initialHealth) : base(playerName, initialHealth)
    {
    }

    
     public void Heal(int healingAmount)
    {
        Health += healingAmount;
        Debug.Log(Name + " healed! New health: " + Health);
    }

   
    void Update()
    {
        
    }
}



