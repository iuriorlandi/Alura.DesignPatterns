namespace Alura.DesignPatterns
{
    /// <summary>
    /// Classe abstrata que representa uma <see cref="Comissao"/>.
    /// </summary>
    public abstract class Comissao
    {
        /// <summary>
        /// Outra <see cref="Comissao"/> cujo o valor será aplicado cumulativamente com a <see cref="Comissao"/> atual.
        /// </summary>
        public Comissao OutraComissao { get; set; }

        /// <summary>
        /// Método de calculo a ser implementado com regras específicas por cada classe que herde de <see cref="Comissao"/>.
        /// </summary>
        /// <param name="orcamento"><see cref="Orcamento"/> sobre o qual será calculada a <see cref="Comissao"/>.</param>
        /// <returns>O valor calculado da <see cref="Comissao"/>.</returns>
        public abstract double CalcularComissao(Orcamento orcamento);

        /// <summary>
        /// Construtor que cria uma nova <see cref="Comissao"/>.
        /// </summary>
        public Comissao()
        {
            OutraComissao = null;
        }

        /// <summary>
        /// Construtor que cria uma nova <see cref="Comissao"/> definindo a <see cref="OutraComissao"/>.
        /// </summary>
        public Comissao(Comissao comissao)
        {
            OutraComissao = comissao;
        }

        /// <summary>
        /// Realiza o calculo de outra <see cref="Comissao"/> cujo valor será aplicado cumulativamente com a atual.
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        protected double CalcularOutraComissao(Orcamento orcamento)
        {
            if (OutraComissao == null)
                return 0;

            return OutraComissao.CalcularComissao(orcamento);
        }
    }
}
