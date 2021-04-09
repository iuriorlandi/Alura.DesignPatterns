using System.Collections.Generic;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Nota fiscal.
    /// </summary>
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Imposto { get; set; }
        public string Observacoes { get; set; }
        public List<Item> Itens { get; set; }

        /// <summary>
        /// Construtor que gera uma nota fiscal completa.
        /// </summary>
        /// <param name="razaoSocial">String a ser atirbuida em <see cref="RazaoSocial"/></param>
        /// <param name="cnpj">String a ser atirbuida em <see cref="Cnpj"/></param>
        /// <param name="valorTotal">Valor a ser atirbuido em <see cref="ValorTotal"/></param>
        /// <param name="imposto">Valor a ser atribuido em <see cref="Imposto"/></param>
        /// <param name="observacoes">String a ser atirbuida em <see cref="Observacoes"/></param>
        /// <param name="itens">Lista de <see cref="Item"/> a ser atribuída em <see cref="Itens"/>.</param>
        public NotaFiscal(string razaoSocial, string cnpj, double valorTotal, double imposto, string observacoes, List<Item> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorTotal = valorTotal;
            Imposto = imposto;
            Observacoes = observacoes;
            Itens = itens;
        }
    }
}
