using System; 

class URI {

    static void Main(string[] args) { 

        int idadeDias = Convert.ToInt32(Console.ReadLine());

        int ano = idadeDias/365;
        idadeDias = idadeDias % 365;

        int mes = idadeDias / 30;
        idadeDias = idadeDias % 30;

        int dias = idadeDias / 1;

        Console.WriteLine($"{ano} ano(s)\n{mes} mes(es)\n{dias} dia(s)");
        
        Console.ReadKey();
    }
}