namespace Alura.DesignPatterns
{
    /// <summary>
    /// Não aplica nenhum desconto (fim da "Chain of Responsability").
    /// </summary>
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalculaDesconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
