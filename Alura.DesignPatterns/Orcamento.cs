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
        /// Valor de um orçamento.
        /// </summary>
        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }

        /// <summary>
        /// Cria um novo orçamento com um <see cref="Orcamento.Valor"/>.
        /// </summary>
        /// <param name="valor">Valor que será atribuído a <see cref="Orcamento.Valor"/>.</param>
        public Orcamento(double valor)
        {
            Valor = valor;
        }
        /// <summary>
        /// Cria um novo orçamento com <see cref="Orcamento.Itens"/>.
        /// </summary>
        /// <param name="itens">Lista de <see cref="Item"/> que será atribuída a <see cref="Orcamento.Itens"/>.</param>
        public Orcamento(IList<Item> itens)
        {
            Itens = itens;
            Valor = itens.Sum(a => a.Valor);
        }
    }
}
