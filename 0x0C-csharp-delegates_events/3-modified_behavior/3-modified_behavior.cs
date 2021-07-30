using System;

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
    ///<summary>lorem ipsum</summary>
    public delegate void CalculateHealth(float amount);
    ///<summary>lorem ipsum</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }
    ///<summary>lorem ipsum</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }
    ///<summary>lorem ipsum</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        } else if (newHp > maxHp)
        {
            hp = maxHp;
        } else
        {
            hp = newHp;
        }
    }
    ///<summary>lorem ipsum</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);
        else if (modifier == Modifier.Base)
            return (baseValue);
        else
            return (baseValue * 1.5f);
    }
}
///<summary>lorem ipsum</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
///<summary>lorem ipsum</summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}
