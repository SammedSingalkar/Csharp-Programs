using System;

class NotPrimeException : Exception
{
    public NotPrimeException()
    {
    }

    public NotPrimeException(string message) : base(message)
    {
    }

    public NotPrimeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

class PrimeNumberGenerator
{
    public static void GeneratePrimeSequence(int start, int count)
    {
        if (!IsPrime(start))
        {
            throw new NotPrimeException("The starting number is not a prime number.");
        }

        int currentNumber = start;
        int primeCount = 0;

        Console.WriteLine("Prime number sequence:");

        while (primeCount < count)
        {
            if (IsPrime(currentNumber))
            {
                Console.Write(currentNumber + " ");
                primeCount++;
            }

            currentNumber++;
        }

        Console.WriteLine();
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            int start = 10; // Starting number that is not prime
            int count = 5;

            PrimeNumberGenerator.GeneratePrimeSequence(start, count);
        }
        catch (NotPrimeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
