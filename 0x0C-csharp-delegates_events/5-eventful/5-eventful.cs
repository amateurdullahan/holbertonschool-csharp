using System;

///<summary>lorem ipsum</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;

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
        this.HPCheck += CheckStatus;
        this.status = name + " is ready to go!";
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
        OnCheckStatus(this, new CurrentHPArgs(this.hp));
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
    ///<summary>lorem ipsum</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            this.status = name + " is in perfect health!";
        }
        else if (e.currentHp >= maxHp * 0.5f)
        {
            this.status = name + " is doing well!";
        }
        else if (e.currentHp >= maxHp * 0.25f)
        {
            this.status = name + " isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            this.status = name + " needs help!";
        }
        else
        {
            this.status = name + " is knocked out!";
        }
        Console.WriteLine(status);
    }
    ///<summary>lorem ipsum</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Health is low!");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    ///<summary>lorem ipsum</summary>
    void OnCheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp < maxHp * 0.25)
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
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
///<summary>lorem ipsum</summary>
class CurrentHPArgs : EventArgs
{
    public float currentHp {get;}
    ///<summary>lorem ipsum</summary>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
