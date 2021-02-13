namespace Alura.DesignPatterns
{
    /// <summary>
    /// Desconto aplicado a <see cref="Orcamento"/>s que possuam <see cref="Orcamento.Valor"/> igual ou superiror a <see langword="500"/>.
    /// </summary>
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