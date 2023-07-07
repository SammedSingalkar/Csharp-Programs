using System;

class Program
{
    delegate int Operation(int num1, int num2);

    static void Main()
    {
        Operation del = Add;
        del += Subtract;
        del += Multiply;

        int result = del(5, 2);

        Console.WriteLine("Result: " + result);
    }

    static int Add(int num1, int num2)
    {
        Console.WriteLine("Adding numbers: " + num1 + " + " + num2);
        return num1 + num2;
    }

    static int Subtract(int num1, int num2)
    {
        Console.WriteLine("Subtracting numbers: " + num1 + " - " + num2);
        return num1 - num2;
    }

    static int Multiply(int num1, int num2)
    {
        Console.WriteLine("Multiplying numbers: " + num1 + " * " + num2);
        return num1 * num2;
    }
}
