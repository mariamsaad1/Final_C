class Program{

    public static void Main(){
        Animal[] Animals= new Animal[3];
        Dog FirstDog = new Dog("Dog", 100);
        Cat FirstCat = new Cat("Cat", 100);
        Bird FirstBird = new Bird("Bird", 100);

        Animals[0]=FirstDog;
        Animals[1]=FirstCat;
        Animals[2]=FirstBird;

      
        for(int i =0; i<Animals.Length; i++){
            Animals[i].MakeSound();
        }

        Console.WriteLine();

        for(int i =0; i<Animals.Length; i++){
            Animals[i].TakeDamage(45);
            Console.WriteLine($"{Animals[i].Name} health: {Animals[i].GetHealth()}");
        }
         Console.WriteLine();

        Console.WriteLine($"Total animals created: {Animal.TotalAnimals}");

        
        


    }
}