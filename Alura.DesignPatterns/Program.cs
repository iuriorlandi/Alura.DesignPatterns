using System;
using System.Collections.Generic;

namespace Alura.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaImpostos();
            Console.WriteLine();
            TestaDescontos();
        }

        private static void TestaImpostos()
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

        private static void TestaDescontos()
        {
            var tv = new Item("TV", 90);
            var geladeira = new Item("Geladeira", 90);

            var orcamento = new Orcamento(new List<Item> { tv, geladeira, tv, geladeira, tv });

            var calculador = new CalculadorDeDesconto();

            double desconto = calculador.CalculaDesconto(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
