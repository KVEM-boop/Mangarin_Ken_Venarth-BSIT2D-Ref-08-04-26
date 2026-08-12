using System;

public class HelloWorld
{
    static public void Main()
    {
        Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        bool fls = true;
        Console.WriteLine("Hello, " + name + " You are " + age + " Years Old! And Weight " + weight.ToString("F2") + "kg and this is " + fls + ".");
    }
}