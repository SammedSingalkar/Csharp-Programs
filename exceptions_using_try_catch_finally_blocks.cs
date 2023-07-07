using System;

class Program
{
    static void Main()
    {
        int dividend, divisor, result;
        try
        {
            Console.Write("Enter dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            result = dividend / divisor;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Error: Arithmetic exception occurred.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
