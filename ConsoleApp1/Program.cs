using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadKey().KeyChar;
        var result = (char)(input +1);
        Console.WriteLine($"\n{result}");
        Main();
    }
}