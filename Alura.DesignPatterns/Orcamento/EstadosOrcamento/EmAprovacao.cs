using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Estado em aprovação.
    /// </summary>
    public class EmAprovacao : EstadoOrcamento
    {
        public void Aprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public double CalcularDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("Somente orcamentos aprovados/reprovados podem ser finalizados.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
