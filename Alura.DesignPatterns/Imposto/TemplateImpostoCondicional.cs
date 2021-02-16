namespace Alura.DesignPatterns
{
    /// <summary>
    /// Classe utilizada para a implementação de um Template Mothod.
    /// </summary>
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (AplicaMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        /// <summary>
        /// Calcula o valor da taxação máxima.
        /// </summary>
        /// <param name="orcamento">Orçamento sobre o qual será calculado o imposto.</param>
        /// <returns>O valor do imposto calculado.</returns>
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        /// <summary>
        /// Calcula o valor da taxação mínima.
        /// </summary>
        /// <param name="orcamento">Orçamento sobre o qual será calculado o imposto.</param>
        /// <returns>O valor do imposto calculado.</returns>
        protected abstract double MinimaTaxacao(Orcamento orcamento);
        /// <summary>
        /// Valida se será aplicada a taxação máxima.
        /// </summary>
        /// <param name="orcamento">Orçamento sobre o qual será calculado o imposto.</param>
        /// <returns>Retorna <see langword="true"/> se o <see cref="Orcamento"/> se enquadra nas regras para taxação máxima e <see langword="false"/> caso contrário.</returns>
        protected abstract bool AplicaMaximaTaxacao(Orcamento orcamento);
    }
}
