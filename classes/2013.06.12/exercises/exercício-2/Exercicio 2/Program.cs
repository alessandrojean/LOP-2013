using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, curso, textoif="", textoen="", textomc="",resp="s";
            double nota;
            while (resp == "s")
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("IF-Informática");
                Console.WriteLine("EN-Eletrônica");
                Console.WriteLine("MC-Mecatrônica");
                Console.Write("Curso: ");
                curso = Console.ReadLine();
                Console.Write("Nota: ");
                nota = double.Parse(Console.ReadLine());
                switch (curso)
                {
                    case "IF":
                        {
                            textoif = textoif + "Nome: " + nome + ". Nota: " + nota + "\n";
                            break;
                        }
                    case "EN":
                        {
                            textoen = textoen + "Nome: " + nome + ". Nota: " + nota + "\n";
                            break;
                        }
                    case "MC":
                        {
                            textomc = textomc + "Nome: " + nome + ". Nota: " + nota + "\n";
                            break;
                        }
                }
                Console.Write("Deseja Continuar (S/N): ");
                resp = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Alunos de IF: ");
            Console.WriteLine(textoif);
            Console.WriteLine("Alunos de EN: ");
            Console.WriteLine(textoen);
            Console.WriteLine("Alunos de MC: ");
            Console.WriteLine(textomc);
            Console.ReadKey();
        }
    }
}
