using System.Linq;

namespace Alura.DesignPatterns
{
    class DescontoCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalculaDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count() >= 5)
                return orcamento.Valor * 0.07;

            return Proximo.CalculaDesconto(orcamento);
        }
    }
}