using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class URI {

    static void Main(string[] args) { 

        int X = Convert.ToInt32(Console.ReadLine());
        
        double Tempo = (X * 2);

        Console.WriteLine($"{Tempo} minutos");

        Console.ReadKey();
    }
}