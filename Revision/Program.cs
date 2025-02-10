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
            if (value > 0 && value < 120)
            {
                age = value;
            } else { 
                throw new Exception($"Age must be greater than 0 and less than 120. Actual {value}");
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

public class Cat : Animal
{

    public void meow()
    {
        if (string.IsNullOrWhiteSpace(Name)) throw new Exception("no name specified");
        Console.WriteLine($"{Name} is meowing.");
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

        Person steve = new Person();
        steve.Name = "Steve";
        steve.Age = 58;
        steve.DisplayInfo();

        // Inheritance example
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Eat();
        dog.Bark();

        Cat cat = new Cat();
        cat.Name = "Sooty";
        cat.Eat();
        cat.meow();

        Cat kitty = new Cat();
        kitty.meow();
    }
}
