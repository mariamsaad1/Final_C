using System;

public class Animal{
    public string Name {get; set;}
    private int Health {get; set;}
    public static int TotalAnimals;
    public Animal(string _Name, int _Health){
        Name = _Name;
        Health = _Health;
        TotalAnimals++;
    }

    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound!");
    }

    public virtual void TakeDamage(int damage){
        Health-= damage;
        // Console.WriteLine($"The Remaining health: {Health}");
    }

    public int GetHealth(){
        return Health;
    }

    public void setHealth(int _Health){
        Health=_Health;
    }
}
