using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_user;
            Console.Write("Digite um Valor: ");
            numero_user = Convert.ToInt32(Console.ReadLine());
            if(numero_user % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5!");
            }
            else
            {
                Console.WriteLine("Não é múltiplo de 5!");
            }
            Console.ReadKey();
        }
    }
}
