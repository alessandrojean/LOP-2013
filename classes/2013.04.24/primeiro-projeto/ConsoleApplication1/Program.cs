using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf;
            Console.Write("Digite o Nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Nome: "+ nome);
            Console.WriteLine("CPF: "+ cpf);
            Console.ReadKey();
        }
    }
}
