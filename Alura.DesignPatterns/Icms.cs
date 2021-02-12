namespace Alura.DesignPatterns
{
    /// <summary>
    /// Implementacão de <see cref="IImposto"/> com as regras aplicáveis ao imposto <see cref="Icms"/>.
    /// </summary>
    public class Icms : IImposto
    {
        /// <summary>
        /// Realiza o cálculo de do Imposto <see cref="Icms"/> sobre um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="orcamento">Modelo que contém o <see cref="Orcamento.Valor"/> sobre o qual o imposto será calculado.</param>
        /// <returns>O valor do imposto calculado.</returns>
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
