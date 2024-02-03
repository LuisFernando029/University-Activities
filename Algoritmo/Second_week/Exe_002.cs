
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, resultado;
            Console.WriteLine("Entre com o valor de 'a': ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o valor de 'b': ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre com o valor de 'c': ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = ((b * b) - 4 * a * c);
            delta = Math.Sqrt(delta);
            resultado = ((-b +delta)/(2*a));
            Console.WriteLine("Valor do x1: "+resultado);
            resultado = ((-b - delta) / (2 * a));
            Console.WriteLine("Valor do x2: "+resultado);
            Console.ReadKey();


        }
    }
}
