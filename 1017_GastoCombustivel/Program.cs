using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

class URI {

    static void Main(string[] args) { 

        int TempoViagem = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        int VelocidadeMedia = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        double QtdLitros = Convert.ToDouble(VelocidadeMedia * TempoViagem) / 12;

        Console.WriteLine($"{QtdLitros.ToString("F3", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }
}