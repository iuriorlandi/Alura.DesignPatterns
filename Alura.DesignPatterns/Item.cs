namespace Alura.DesignPatterns
{
    public class Item
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Item(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
