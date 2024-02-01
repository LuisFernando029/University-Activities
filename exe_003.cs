using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data_nascimento_usuario, ano_atual, idade_usuario;
            Console.WriteLine("Digite o ano de nascimento: ");
            data_nascimento_usuario = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano_atual = Convert.ToInt32( Console.ReadLine());
            idade_usuario = (ano_atual - data_nascimento_usuario);
            Console.WriteLine("Sua idade é: "+idade_usuario);
            Console.ReadKey();
        }
    }
}
