namespace Alura.DesignPatterns
{
    /// <summary>
    /// Interface a ser implementada por tipos de desconto.
    /// </summary>
    public interface IDesconto
    {
        /// <summary>
        /// Próximo desconto a ser chamado dentro de uma "Chain of Responsability".
        /// </summary>
        public IDesconto Proximo { get; set; }
        /// <summary>
        /// Realiza o cálculo de um desconto.
        /// </summary>
        /// <param name="orcamento">Orçamento ao qual será aplicado o desconto.</param>
        /// <returns>Valor do desconto.</returns>
        double CalculaDesconto(Orcamento orcamento);
    }
}
