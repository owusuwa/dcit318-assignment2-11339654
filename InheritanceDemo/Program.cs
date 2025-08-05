using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Wolf : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Howl");
    }
}

class Koala : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bellow");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Wolf myWolf = new Wolf();
        Koala myKoala = new Koala();

        myAnimal.MakeSound(); // Output: Some generic sound
        myWolf.MakeSound();    // Output: Howl
        myKoala.MakeSound();    // Output: Bellow
    }
}

