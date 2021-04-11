namespace Alura.DesignPatterns
{
    /// <summary>
    /// Interface a ser implementada por todas as Ações realizadas após a geração de uma <see cref="NotaFiscal"/>.
    /// </summary>
    public interface IAcaoAposCriarNota
    {
        /// <summary>
        /// Executa uma ação após gerar uma <see cref="NotaFiscal"/>.
        /// </summary>
        /// <param name="nf"><see cref="NotaFiscal"/> gerada.</param>
        void Executa(NotaFiscal nf);
    }
}
