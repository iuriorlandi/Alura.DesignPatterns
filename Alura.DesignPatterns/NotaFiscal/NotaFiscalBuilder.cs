using System.Collections.Generic;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Builder de <see cref="NotaFiscal"/>.
    /// </summary>
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Imposto { get; set; }
        public string Observacoes { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        public List<IAcaoAposCriarNota> AcoesAposCriarNota { get; set; } = new List<IAcaoAposCriarNota>();

        /// <summary>
        /// Atribui uma <see cref="RazaoSocial"/>
        /// </summary>
        /// <param name="razaoSocial">String a ser atribuída em <see cref="RazaoSocial"/></param>
        /// <returns>Retorna o <see cref="NotaFiscalBuilder"/> que chamou o método (<see langword="this"/>).</returns>
        public NotaFiscalBuilder ParaRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        /// <summary>
        /// Atribui uma <see cref="Cnpj"/>
        /// </summary>
        /// <param name="cnpj">String a ser atribuída em <see cref="Cnpj"/></param>
        /// <returns>Retorna o <see cref="NotaFiscalBuilder"/> que chamou o método (<see langword="this"/>).</returns>
        public NotaFiscalBuilder ParaCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        /// <summary>
        /// Adiciona um <see cref="Item"/> aos <see cref="Itens"/>.
        /// </summary>
        /// <param name="item"><see cref="Item"/> a ser adicionado.</param>
        /// <returns>Retorna o <see cref="NotaFiscalBuilder"/> que chamou o método (<see langword="this"/>).</returns>
        public NotaFiscalBuilder AdicionarItem(Item item)
        {
            Itens.Add(item);
            ValorTotal += item.Valor;
            Imposto += item.Valor * 0.05;
            return this;
        }

        /// <summary>
        /// Atribui <see cref="Observacoes"/>
        /// </summary>
        /// <param name="observacoes">String a ser atribuída em <see cref="Observacoes"/></param>
        /// <returns>Retorna o <see cref="NotaFiscalBuilder"/> que chamou o método (<see langword="this"/>).</returns>
        public NotaFiscalBuilder AdicionarObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        /// <summary>
        /// Gera uma <see cref="NotaFiscal"/> com os dados passados para o Builder.
        /// </summary>
        /// <returns>Retorna uma nova <see cref="NotaFiscal"/>.</returns>
        public NotaFiscal GerarNotaFiscal()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, ValorTotal, Imposto, Observacoes, Itens);

            foreach (var acao in AcoesAposCriarNota)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionarAcaoAposCriarNota(IAcaoAposCriarNota novaAcao)
        {
            AcoesAposCriarNota.Add(novaAcao);
        }
    }
}
