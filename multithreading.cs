using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create and start the first thread
        Thread thread1 = new Thread(CountNumbers);
        thread1.Start(1); // Pass starting number as 1

        // Create and start the second thread
        Thread thread2 = new Thread(CountNumbers);
        thread2.Start(11); // Pass starting number as 11

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();

        Console.WriteLine("All threads have completed.");
    }

    static void CountNumbers(object startObj)
    {
        int start = (int)startObj;

        for (int i = start; i <= start + 9; i++)
        {
            Console.WriteLine("Thread ID: " + Thread.CurrentThread.ManagedThreadId + " - Number: " + i);
            Thread.Sleep(100); // Sleep for 100 milliseconds
        }
    }
}
