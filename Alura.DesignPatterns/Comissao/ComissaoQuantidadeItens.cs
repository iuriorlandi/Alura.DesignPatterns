using System.Linq;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Comissão calculada sobre a quantidade de <see cref="Orcamento.Itens"/>.
    /// </summary>
    public class ComissaoQuantidadeItens : Comissao
    {

        /// <summary>
        /// Construtor que cria uma nova <see cref="ComissaoQuantidadeItens"/>.
        /// </summary>
        public ComissaoQuantidadeItens()
        {
        }

        /// <summary>
        /// Construtor que cria uma nova <see cref="ComissaoQuantidadeItens"/> definindo a <see cref="OutraComissao"/>.
        /// </summary>
        public ComissaoQuantidadeItens(Comissao comissao) : base (comissao)
        {
        }


        public override double CalcularComissao(Orcamento orcamento)
        {
            var percentual = (orcamento.Itens.Count() / (double)100);
            return (percentual * orcamento.Valor) + CalcularOutraComissao(orcamento);

        }
    }
}
