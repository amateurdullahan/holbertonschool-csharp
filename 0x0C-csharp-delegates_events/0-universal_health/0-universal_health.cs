﻿using System;

///<summary>lorem ipsum</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

    ///<summary>lorem ipsum</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
            this.hp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }
    
    ///<summary>lorem ipsum</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
