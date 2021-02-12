namespace Alura.DesignPatterns
{
    /// <summary>
    /// Interface a ser implementada por classes com regras específicas de imposto.
    /// </summary>
    public interface IImposto
    {
        /// <summary>
        /// Realiza o cálculo de imposto sobre um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="orcamento">Modelo que contém o <see cref="Orcamento.Valor"/> sobre o qual o imposto será calculado.</param>
        /// <returns>O valor do imposto calculado.</returns>
        double Calcula(Orcamento orcamento);
    }
}
