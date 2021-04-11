using System;

namespace Alura.DesignPatterns
{
    /// <summary>
    /// Classe responsável por simular o envio de SMS.
    /// </summary>
    public class EnviadorSms : IAcaoAposCriarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Sms");
        }
    }
}
