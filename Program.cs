using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("Enter a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + " + " + b + " = " + (a + b));
    }
}

