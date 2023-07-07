using System;

class Program
{
    delegate int Del(int num);

    static void Main()
    {
        Del del = MultiplyNumbers;

        for (int i = 1; i <= 5; i++)
        {
            int result = del(i);
            Console.WriteLine("Result: " + result);
        }
    }

    static int MultiplyNumbers(int num)
    {
        return num * 2;
    }
}
