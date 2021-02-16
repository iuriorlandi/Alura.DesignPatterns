using System.Collections.Generic;

namespace Alura.DesignPatterns
{
    public class IKCV : TemplateImpostoCondicional
    {
        protected override bool AplicaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorMaiorQueCem(orcamento.Itens);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemComValorMaiorQueCem(IList<Item> itens)
        {
            foreach (var item in itens)
            {
                if (item.Valor > 100)
                    return true;
            };

            return false;
        }
    }
}
