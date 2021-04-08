namespace Alura.DesignPatterns
{
    /// <summary>
    /// Interface a ser implementada por todos os possíveis estados de um <see cref="Orcamento"/>.
    /// </summary>
    public interface EstadoOrcamento
    {
        /// <summary>
        /// Calcula um desconto extra para um <see cref="Orcamento"/> dependendo de seu <see cref="Orcamento.Estado"/>.
        /// </summary>
        /// <param name="orcamento"><see cref="Orcamento"/> sobre o qual será calculado o desconto.</param>
        /// <returns>Retorna o valor do desconto.</returns>
        double CalcularDescontoExtra(Orcamento orcamento);
        /// <summary>
        /// Aprova um <see cref="Orcamento"/>.
        /// </summary>
        /// <param name="orcamento"><see cref="Orcamento"/> a ser aprovado.</param>
        void Aprovar(Orcamento orcamento);
        /// <summary>
        /// Reprova um <see cref="Orcamento"/>.
        /// </summary>
        /// <param name="orcamento"><see cref="Orcamento"/> a ser reprovado.</param>
        void Reprovar(Orcamento orcamento);
        /// <summary>
        /// Finaliza um <see cref="Orcamento"/>.
        /// </summary>
        /// <param name="orcamento"><see cref="Orcamento"/> a ser finalizado.</param>
        void Finalizar(Orcamento orcamento);
    }
}
