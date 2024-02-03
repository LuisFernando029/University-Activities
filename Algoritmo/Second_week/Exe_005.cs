using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, lastName, email;
            int index_nome, index_lastName;
            Console.Write("DIGITE SEU NOME COMPLETO: ");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            nome = nome.Trim();

            index_nome = nome.IndexOf(" ");
            index_lastName = nome.LastIndexOf(" ") + 1;
            lastName = nome.Substring(index_lastName);
            nome = nome.Substring(0, index_nome);

            email = nome + (".") + lastName + ("@fatec.sp.gov.br");
            Console.WriteLine("Aqui está o seu email: " + email);
            Console.ReadKey();
        }
    }
}
