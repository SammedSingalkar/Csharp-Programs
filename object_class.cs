using System;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    // Additional members and functionality can be added here
}

class Program
{
    static void Main()
    {
        Point p = new Point(10, 20);
        Console.WriteLine(p.ToString());

        // You can also access the inherited members from the Object class
        Console.WriteLine("Type: " + p.GetType());
        Console.WriteLine("HashCode: " + p.GetHashCode());
        Console.WriteLine("Equals: " + p.Equals(p));
    }
}
