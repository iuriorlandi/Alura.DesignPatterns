namespace Alura.DesignPatterns
{
    public class DescontoValorMaiorQueQuinhentos : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalculaDesconto(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
                return orcamento.Valor * 0.05;

            return Proximo.CalculaDesconto(orcamento);
        }
    }
}