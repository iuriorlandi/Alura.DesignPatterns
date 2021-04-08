using System.Collections.Generic;
using System.Linq;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Orçamento.
    /// </summary>
    public class Orcamento
    {
        /// <summary>
        /// Valor de um <see cref="Orcamento"/>.
        /// </summary>
        public double Valor { get; private set; }
        /// <summary>
        /// Itens de um <see cref="Orcamento"/>.
        /// </summary>
        public IList<Item> Itens { get; set; }
        /// <summary>
        /// Estado de um <see cref="Orcamento"/>.
        /// </summary>
        public EstadoOrcamento Estado { get; set; }

        /// <summary>
        /// Cria um novo orçamento com um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="valor">Valor que será atribuído a <see cref="Orcamento.Valor"/>.</param>
        public Orcamento(double valor)
        {
            Estado = new EmAprovacao();
            Valor = valor;
        }
        /// <summary>
        /// Cria um novo orçamento com <see cref="Orcamento.Itens"/>.
        /// </summary>
        /// <param name="itens">Lista de <see cref="Item"/> que será atribuída a <see cref="Orcamento.Itens"/>.</param>
        public Orcamento(IList<Item> itens)
        {
            Estado = new EmAprovacao();
            Itens = itens;
            Valor = itens.Sum(a => a.Valor);
        }

        /// <summary>
        /// Aplica um desconto Extra.
        /// </summary>
        public void AplicarDescontoExtra()
        {
            Valor -= Estado.CalcularDescontoExtra(this);
        }

        /// <summary>
        /// Aprova o <see cref="Orcamento"/>.
        /// </summary>
        public void Aprovar() => Estado.Aprovar(this);

        /// <summary>
        /// Reprova o <see cref="Orcamento"/>.
        /// </summary>
        public void Reprovar() => Estado.Reprovar(this);

        /// <summary>
        /// Finaliza o <see cref="Orcamento"/>.
        /// </summary>
        public void Finalizar() => Estado.Finalizar(this);
    }
}
