namespace Alura.DesignPatterns
{
    public class CalculadorDeDesconto
    {
        public double CalculaDesconto(Orcamento orcamento)
        {
            var primeiroDesconto = new DescontoValorMaiorQueQuinhentos();
            var segundoDesconto = new DescontoCincoItens();
            var terceiroDesconto = new SemDesconto();

            primeiroDesconto.Proximo = segundoDesconto;
            segundoDesconto.Proximo = terceiroDesconto;

            return primeiroDesconto.CalculaDesconto(orcamento);
        }
    }
}
