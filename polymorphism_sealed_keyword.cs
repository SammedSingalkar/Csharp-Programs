using System;

class StudentResult
{
    public virtual void DisplayGrade()
    {
        Console.WriteLine("No grade available");
    }
}

class FinalResult : StudentResult
{
    public sealed override void DisplayGrade()
    {
        Console.WriteLine("Final Grade: A+");
    }
}

// The following line will cause a compilation error since the FinalResult class is sealed
// class ExtraResult : FinalResult { }

class Program
{
    static void Main()
    {
        StudentResult studentResult = new StudentResult();
        Console.WriteLine("Student Result:");
        studentResult.DisplayGrade();

        Console.WriteLine();

        FinalResult finalResult = new FinalResult();
        Console.WriteLine("Final Result:");
        finalResult.DisplayGrade();
    }
}
