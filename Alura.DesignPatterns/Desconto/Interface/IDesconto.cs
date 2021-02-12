namespace Alura.DesignPatterns
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        double CalculaDesconto(Orcamento orcamento);
    }
}
