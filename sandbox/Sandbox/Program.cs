using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("Please input your name:  ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your name is: {firstName}  ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {lastName}, {firstName}  ");g
    }
}