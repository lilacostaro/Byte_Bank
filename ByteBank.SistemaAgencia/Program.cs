using System;
//using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace Bytebank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            Console.WriteLine(conta.Numero);

            new ContaCorrente(458, 58987);

            DateTime dataFimPagamento = new DateTime(2023, 12, 15);

            DateTime dataCorente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorente;

            Console.WriteLine(dataCorente);
            Console.WriteLine(dataFimPagamento);

            string mensagem = $"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca)}";
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
        