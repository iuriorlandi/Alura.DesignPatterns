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

        /// <summary>
        /// Realiza teste de cálculo de imposto utilizando o padrão Strategy.
        /// </summary>
        private static void TestaImpostos()
        {
            var orcamento = new Orcamento(500);
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();

            Console.WriteLine(icms.Calcula(orcamento));

            Console.WriteLine(iss.Calcula(orcamento));

            Console.WriteLine(iccc.Calcula(orcamento));

            Console.ReadKey();
        }
        /// <summary>
        /// Realiza teste de aplicação de desconto utilizando o padrão Chain of Responsabily.
        /// </summary>
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
