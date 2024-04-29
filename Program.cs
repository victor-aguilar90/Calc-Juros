using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcJuros
{
    internal class Program
    {

        static double Montante(double capital, double taxa, double tempo)
        {
            taxa = taxa / 100;
            return capital * (Math.Pow(1+taxa, tempo));
        }
        static void Main(string[] args)
        {
            double c, j, t;

            Console.WriteLine("Digite o valor investido: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros do investimento: ");
            j = double.Parse(Console.ReadLine());

            Console.WriteLine("DIgite o tempo do investimento: ");
            t = double.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                Console.WriteLine("Ano: {0} Capital: {1} Montante: {2:0.00}  Lucro/Ano: {3:0.00} Lucro Acumulado: {4:0.00}",i, c, Montante(c, j, i), Montante(c, j, i)-Montante(c, j, i-1), Montante(c,j,i)-c);
            }
        }
    }
}
