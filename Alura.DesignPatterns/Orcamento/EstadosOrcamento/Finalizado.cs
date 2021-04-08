using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Estado finalizado.
    /// </summary>
    public class Finalizado : EstadoOrcamento
    {
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Um orçamento finalizado não pode mais ser aprovado.");
        }

        public double CalcularDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento reprovado não pode mais receber desconto.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está finalizado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("Um orçamento finalizado não pode mais ser reprovado.");
        }
    }
}
