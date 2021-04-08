using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Estado aprovado.
    /// </summary>
    public class Aprovado : EstadoOrcamento
    {
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("O orcamento já está aprovado.");
        }

        public double CalcularDescontoExtra(Orcamento orcamento)
        {
            return orcamento.Valor * 0.02;
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Um orçamento aprovado não pode mais ser reprovado.");
        }
    }
}
