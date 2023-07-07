using System;

class Grandparent
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Grandparent(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Parent : Grandparent
{
    public string Education { get; set; }

    public Parent(string name, int age, string education)
        : base(name, age)
    {
        Education = education;
    }
}

class Child : Parent
{
    public string MaritalStatus { get; set; }

    public Child(string name, int age, string education, string maritalStatus)
        : base(name, age, education)
    {
        MaritalStatus = maritalStatus;
    }
}

class Program
{
    static void Main()
    {
        Grandparent grandparent = new Grandparent("John Doe", 70);
        Console.WriteLine("Grandparent:");
        DisplayInfo(grandparent);

        Parent parent = new Parent("Jane Smith", 45, "Bachelor's Degree");
        Console.WriteLine("\nParent:");
        DisplayInfo(parent);

        Child child = new Child("Tom Johnson", 20, "High School", "Single");
        Console.WriteLine("\nChild:");
        DisplayInfo(child);

        // Type checking with 'is' keyword
        if (grandparent is Parent)
        {
            Console.WriteLine("\nGrandparent is a Parent");
        }
        else
        {
            Console.WriteLine("\nGrandparent is not a Parent");
        }

        if (parent is Grandparent)
        {
            Console.WriteLine("Parent is a Grandparent");
        }
        else
        {
            Console.WriteLine("Parent is not a Grandparent");
        }

        // Type casting with 'as' keyword
        Parent parent2 = grandparent as Parent;
        if (parent2 != null)
        {
            Console.WriteLine("\nCasting Grandparent to Parent successful");
            DisplayInfo(parent2);
        }
        else
        {
            Console.WriteLine("\nCasting Grandparent to Parent unsuccessful");
        }

        Child child2 = parent as Child;
        if (child2 != null)
        {
            Console.WriteLine("Casting Parent to Child successful");
            DisplayInfo(child2);
        }
        else
        {
            Console.WriteLine("Casting Parent to Child unsuccessful");
        }
    }

    static void DisplayInfo(Grandparent person)
    {
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}
