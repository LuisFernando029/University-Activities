using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario_cliente, valor_prestacao;
            Console.Write("Informe sua renda mensal: ");
            salario_cliente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor previsto para cada prestação: ");
            valor_prestacao = Convert.ToDouble(Console.ReadLine());
            if(valor_prestacao > (salario_cliente * 0.3))
            {
                Console.WriteLine("Empréstimo não permitido por exceder o limite previsto");
            }
            else
            {
                Console.WriteLine("Empréstimo permitido");
            }
        }
    }
}
