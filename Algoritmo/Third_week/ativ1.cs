using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero_user;
            Console.Write("Digite um valor: ");
            numero_user = Convert.ToDouble(Console.ReadLine());
            if(numero_user >= 20)
            {
                Console.WriteLine("A metade do valor: " + (numero_user / 2));
            }
            else
            {
                Console.WriteLine("O dobro do valor: " + (numero_user * 2));
            }
            Console.ReadKey();  
        }
    }
}
