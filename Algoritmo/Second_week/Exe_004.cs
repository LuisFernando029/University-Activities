using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int index;
            Console.Write("DIGITE SEU NOME COMPLETO: ");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            index = nome.IndexOf(" ");
            nome = nome.Substring(0, index);
            email = nome + ("@fatec.sp.gov.br");
            Console.WriteLine("Aqui está o seu email: "+email);
            Console.ReadKey();
        }
    }
}
