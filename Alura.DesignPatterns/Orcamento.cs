namespace Alura.DesignPatterns
{
    /// <summary>
    /// Orçamento.
    /// </summary>
    public class Orcamento
    {
        /// <summary>
        /// Valor de um orçamento.
        /// </summary>
        public double Valor { get; private set; }

        /// <summary>
        /// Cria um novo orçamento com um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="valor">Valor que será atribuído a <see cref="Orcamento.Valor"/>.</param>
        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
