using System;

interface IGrade
{
    void CalculateGrade();
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Student : Person, IGrade
{
    public int RollNumber { get; set; }
    public int Marks { get; set; }

    public Student(string name, int age, int rollNumber, int marks)
        : base(name, age)
    {
        RollNumber = rollNumber;
        Marks = marks;
    }

    public void CalculateGrade()
    {
        string grade;
        if (Marks >= 90)
            grade = "A+";
        else if (Marks >= 80)
            grade = "A";
        else if (Marks >= 70)
            grade = "B";
        else if (Marks >= 60)
            grade = "C";
        else if (Marks >= 50)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine("Grade: " + grade);
    }
}

class Program
{
    static void Main()
    {
        string name = "John Doe";
        int age = 20;
        int rollNumber = 12345;
        int marks = 85;

        Student student = new Student(name, age, rollNumber, marks);

        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Roll Number: " + student.RollNumber);
        Console.WriteLine("Marks: " + student.Marks);

        student.CalculateGrade();
    }
}
