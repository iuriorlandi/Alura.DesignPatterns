namespace Alura.DesignPatterns
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalculaDesconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
