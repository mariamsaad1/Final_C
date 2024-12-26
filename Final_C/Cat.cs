using System;

public class Cat : Animal{

    public Cat(string _Name, int _Health) : base(_Name, _Health)
    {
    }

    public override void MakeSound(){
        Console.WriteLine("The cat meows loudly!");
    }

    public override void TakeDamage(int damage){
        int Health= base.GetHealth();
        Health-= (damage/2);
        base.setHealth(Health);
        // Console.WriteLine($"The Remaining health: {Health}");
    }
}

