using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome);
            Console.ReadKey();
        }
    }
}
