namespace Alura.DesignPatterns
{
    /// <summary>
    /// Classe que representa um item de um <see cref="Orcamento"/>.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Descrição do item.
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Valor do item.
        /// </summary>
        public double Valor { get; set; }

        /// <summary>
        /// Cria um <see cref="Item"/> atribuindo uma <see cref="Descricao"/> e um <see cref="Valor"/>.
        /// </summary>
        /// <param name="descricao">Descrição a ser atribuída em <see cref="Descricao"/>.</param>
        /// <param name="valor">Valor a ser atribuído em <see cref="Valor"/>.</param>
        public Item(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
