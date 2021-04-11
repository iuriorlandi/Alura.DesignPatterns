using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Classe responsável por simular o envio de Email.
    /// </summary>
    public class EnviadorEmail : IAcaoAposCriarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Email.");
        }
    }
}
