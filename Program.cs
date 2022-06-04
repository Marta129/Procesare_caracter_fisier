using System;

namespace Procesare_caractere_fisier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele fisierului:");
            Procesare procesare = new Procesare();
            Console.WriteLine("In fisier sunt:{0} vocale", procesare.Vocale);
            Console.WriteLine("In fisier sunt:{0} consoane", procesare.Consoane);
            Console.WriteLine("In fisier sunt:{0} linii", procesare.Linii);
            Console.WriteLine("In fisier sunt:{0} caractere", procesare.Total);

        }
    }
}
