using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Estado reprovado.
    /// </summary>
    public class Reprovado : EstadoOrcamento
    {
        public void Aprovar(Orcamento orcamento)
        {
            throw new Exception("Um orçamento reprovado não pode mais ser aprovado.");
        }

        public double CalcularDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento reprovado não pode mais receber desconto.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new Exception("O orcamento já está reprovado.");
        }
    }
}
