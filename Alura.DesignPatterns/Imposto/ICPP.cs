namespace Alura.DesignPatterns
{
    /// <summary>
    /// Implementacão de <see cref="IImposto"/> com as regras aplicáveis ao imposto <see cref="ICPP"/>.
    /// </summary>
    public class ICPP : TemplateImpostoCondicional
    {
        protected override bool AplicaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
