namespace Alura.DesignPatterns
{
    /// <summary>
    /// Implementacão de <see cref="IImposto"/> com as regras aplicáveis ao imposto <see cref="Iccc"/>.
    /// </summary>
    public class Iccc : IImposto
    {
        /// <summary>
        /// Realiza o cálculo de do Imposto <see cref="Iccc"/> sobre um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="orcamento">Modelo que contém o <see cref="Orcamento.Valor"/> sobre o qual o imposto será calculado.</param>
        /// <returns>O valor do imposto calculado.</returns>
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor <= 1000)
                return orcamento.Valor * 0.05;

            if (orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07;

            return (orcamento.Valor * 0.08) + 30;
        }
    }
}
