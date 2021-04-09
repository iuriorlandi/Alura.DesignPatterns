using System;
using System.Collections.Generic;

namespace Alura.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaImpostos();
            TestaDescontos();
            TestaComissoes();
            TestaEstados();
            TestaNotaFiscal();
        }

        /// <summary>
        /// Realiza Teste de Nota Fiscal utilizando o padrão Builder.
        /// </summary>
        private static void TestaNotaFiscal()
        {
            EscreveCabecalho("Teste Nota Fiscal.");

            var nfBuilder = new NotaFiscalBuilder();
            var tv = new Item("Tv", 1500);
            var geladeira = new Item("Geladeira", 2500);


            nfBuilder
                .ParaRazaoSocial("Teste LTDA")
                .ParaCnpj("12.345.678/0001-01")
                .AdicionarItem(tv)
                .AdicionarItem(geladeira)
                .AdicionarObservacoes("Nota fiscal de teste");

            var nf = nfBuilder.GerarNotaFiscal();

            Console.WriteLine(nf.ValorTotal);
            Console.WriteLine(nf.Imposto);
            Console.ReadKey();
        }

        /// <summary>
        /// Realiza teste dos <see cref="EstadoOrcamento"/> utilizado o padrão State.
        /// </summary>
        private static void TestaEstados()
        {
            EscreveCabecalho("Teste Estados.");
            var orcamento = new Orcamento(1000);

            orcamento.AplicarDescontoExtra();

            Console.WriteLine(orcamento.Valor);

            orcamento.Aprovar();

            orcamento.AplicarDescontoExtra();

            Console.WriteLine(orcamento.Valor);

            orcamento.Finalizar();
            Console.ReadKey();
        }

        private static void EscreveCabecalho(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine(titulo);
            Console.WriteLine();
        }

        /// <summary>
        /// Realiza teste de cálculo de imposto utilizando o padrão Strategy.
        /// </summary>
        private static void TestaImpostos()
        {
            EscreveCabecalho("Teste Impostos.");

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
            EscreveCabecalho("Teste Descontos.");

            var tv = new Item("TV", 90);
            var geladeira = new Item("Geladeira", 90);

            var orcamento = new Orcamento(new List<Item> { tv, geladeira, tv, geladeira, tv });

            var calculador = new CalculadorDeDesconto();

            double desconto = calculador.CalculaDesconto(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }

        /// <summary>
        /// Realiza teste de cálculo de comissão utilizando o padrão Decorator.
        /// </summary>
        public static void TestaComissoes()
        {
            EscreveCabecalho("Teste Comissoes.");

            var tv = new Item("TV", 1000);
            var geladeira = new Item("Geladeira", 2000);

            var orcamento = new Orcamento(new List<Item> { tv, geladeira });

            var comissao = new ComissaoValorTotal(new ComissaoQuantidadeItens());
            var valorComissao = comissao.CalcularComissao(orcamento);

            Console.WriteLine(valorComissao);
            Console.ReadKey();
        }
    }
}
