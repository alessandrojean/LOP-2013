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
            string resp = "s";
            double capital = 0, taxa = 0, capitalx = 0;
            int tempo = 0, i=0;
            while (resp == "s")
            {
                Console.Write("Capital: ");
                capital = Double.Parse(Console.ReadLine());
                Console.Write("Taxa: ");
                taxa = Double.Parse(Console.ReadLine());
                Console.Write("Tempo: ");
                tempo = int.Parse(Console.ReadLine());
                for (i = 0; i != tempo; i++)
                {
                    capitalx = capital + capital * taxa / 100;
                    Console.WriteLine(capital + " " + capital * taxa / 100 + " " + capitalx);
                    capital = capitalx;
                }
                Console.Write("Deseja continuar s/n: ");
                resp = Console.ReadLine();
            }
              
        }
    }
}
