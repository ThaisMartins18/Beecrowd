using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

class URI {

    static void Main(string[] args) { 

        int X = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        double Y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Consumo = X / Y;

        Console.WriteLine($"{Consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");

        Console.ReadKey();
        
    }

}