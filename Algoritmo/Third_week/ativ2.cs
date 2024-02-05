using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("O maior valor é: " + numero1);
            }
            else if (numero2 > numero1) 
            {
                Console.WriteLine("O maior valor é: "+ numero2);
            }
            else   
            {
                Console.WriteLine("Os números possuem o mesmo valor");
            }
            Console.ReadKey();
        }
    }
}
