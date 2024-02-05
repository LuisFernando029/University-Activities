using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero_user;
            Console.Write("Digite um valor: ");
            numero_user = Convert.ToDouble(Console.ReadLine());
            if( numero_user > 0)
            {
                Console.WriteLine("Número positivo! ");
            }
            else if( numero_user < 0)
            {
                Console.WriteLine("Número negativo! ");
            }
            else
            {
                Console.WriteLine("Número igual a zero");
            }
            Console.ReadKey();
        }
    }
}
