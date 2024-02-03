using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exe_001_alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiro_valor, segundo_valor, resultado_operacao;
            Console.WriteLine("Digite o primeiro valor: ");
            primeiro_valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            segundo_valor = Convert.ToDouble(Console.ReadLine());
            resultado_operacao = (primeiro_valor + segundo_valor);
            Console.WriteLine("Soma: " + resultado_operacao);        
            resultado_operacao = (primeiro_valor -  segundo_valor);
            Console.WriteLine("Subtração: " + resultado_operacao);
            resultado_operacao = (primeiro_valor * segundo_valor);
            Console.WriteLine("Multiplicação: " + resultado_operacao);
            resultado_operacao = (primeiro_valor / segundo_valor);
            Console.WriteLine("Divisão: " + resultado_operacao);
            Console.ReadKey();

        }
    }
}
