using System;

public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set 
        { 
            if (value > 0)
            {
                age = value;
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

public class Program
{
    public static void Main()
    {
        // Encapsulation example
        Person person = new Person();
        person.Name = "Alice";
        person.Age = 30;
        person.DisplayInfo();

        // Inheritance example
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Eat();
        dog.Bark();
    }
}
