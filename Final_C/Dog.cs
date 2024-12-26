using System;

public class Dog : Animal{

    // public bool HasLeash;
    public enum HasLeash {HasLeash ,NotHasLeash};
    public Dog(string _Name, int _Health) : base(_Name, _Health)
    {
    }

    public override void MakeSound(){
        Console.WriteLine("The dog barks loudly!");
    }
}
