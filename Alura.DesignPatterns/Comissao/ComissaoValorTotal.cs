using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Comissão calculada sobre o <see cref="Orcamento.Valor"/>.
    /// </summary>
    public class ComissaoValorTotal : Comissao
    {

        /// <summary>
        /// Construtor que cria uma nova <see cref="ComissaoValorTotal"/>.
        /// </summary>
        public ComissaoValorTotal()
        {
        }

        /// <summary>
        /// Construtor que cria uma nova <see cref="ComissaoValorTotal"/> definindo a <see cref="OutraComissao"/>.
        /// </summary>
        public ComissaoValorTotal(Comissao comissao) : base(comissao) 
        {
        }

        public override double CalcularComissao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + CalcularOutraComissao(orcamento);
        }
    }
}
