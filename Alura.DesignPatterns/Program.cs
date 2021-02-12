using System;

namespace Alura.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(500);
            var icms = new Icms();
            var iss = new Iss();
            var iccc = new Iccc();

            Console.WriteLine(icms.Calcula(orcamento));

            Console.WriteLine(iss.Calcula(orcamento));

            Console.WriteLine(iccc.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
