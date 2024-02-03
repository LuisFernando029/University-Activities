using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome_completo, nome, sobrenome, conteudo_string;
            int index_separador;
            Console.Write("Digite seu nome e sobrenome: ");
            nome_completo = Console.ReadLine();
            index_separador = nome_completo.IndexOf(" ");
            sobrenome = nome_completo.Substring(++index_separador);
            nome = nome_completo.Substring(0, index_separador);
            conteudo_string = nome_completo.Substring(5, 5);
            nome_completo = nome_completo.Replace("a", "e");
            Console.WriteLine("Conteudo da string: "+conteudo_string);
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Sobrenome: "+sobrenome);
           // Console.WriteLine("Nome não binário: "+ nome_completo);
            Console.WriteLine("Replace: "+ nome_completo);

            Console.ReadKey();




        }
    }
}
