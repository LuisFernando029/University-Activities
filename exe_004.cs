using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeira_nota, segunda_nota, terceira_nota, media;
            Console.WriteLine("Digite a primeira nota: ");
            primeira_nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            segunda_nota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            terceira_nota = Convert.ToDouble(Console.ReadLine());
            media = ((primeira_nota+segunda_nota+terceira_nota)/3);
            Console.WriteLine("Média aritmética: " + media);
            Console.ReadKey();
        }
    }
}
