using System;

public class Bird : Animal{

    // public bool InCage;

    public enum InCage {InCage ,NotInCage};
    public Bird(string _Name, int _Health) : base(_Name, _Health)
    {
    }

    public override void MakeSound(){
        Console.WriteLine("The bird chirps melodiously!");
    }

}
