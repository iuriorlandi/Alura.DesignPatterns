﻿namespace Alura.DesignPatterns
{
    public abstract class TemplateImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (AplicaMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
        protected abstract bool AplicaMaximaTaxacao(Orcamento orcamento);
    }
}
