using System;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public void MakeNoise()
    {
        Console.WriteLine(Name + " says Ham");
    }
}