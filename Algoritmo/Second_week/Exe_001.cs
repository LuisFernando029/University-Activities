
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, diametro, pi, area, perimetro;
            pi = Math.PI;
            pi = Math.Round(pi, 2);
            Console.WriteLine("Digite o Valor do Raio");
            raio = Convert.ToDouble(Console.ReadLine());
            Math.Pow(raio, 2);
            area = pi * (raio * raio);
            diametro = 2 * raio;
            perimetro = 2 * pi * raio;
            Console.WriteLine("O Valor da Area é: " + area);
            Console.WriteLine("O Valor do diametro é: " + diametro);
            Console.WriteLine("O Valor do perimetro é: " + perimetro);
            Console.ReadKey();
        }
    }
}
