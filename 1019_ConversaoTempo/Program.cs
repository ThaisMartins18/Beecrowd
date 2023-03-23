using System;

class URI
{
    static void Main(string[] args)
    {

        int segundos = int.Parse(Console.ReadLine());

        Console.WriteLine($"{segundos/3600}:{(segundos%3600)/60}:{segundos%60}");

        Console.ReadKey();
    }
}




