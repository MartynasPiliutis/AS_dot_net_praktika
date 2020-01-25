using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal minutes = 2m;
            decimal valandos = 2m;
            decimal mazojiRodykle;
            decimal didziojiRodykle;
            decimal kampas;
            Console.Write("Iveskite valandas: ");
            valandos = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Iveskite minutes: ");
            minutes = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Ivestas laikas yra {valandos, 2}:{minutes, 2}");
            Console.ReadLine();
            didziojiRodykle = 6 * minutes;
            mazojiRodykle = 30 * valandos + 0.50m * minutes;
            kampas = mazojiRodykle - didziojiRodykle;
            Console.WriteLine($"Dizioji rodykle {didziojiRodykle} laipsniai");
            Console.WriteLine($"Mazoji rodykle {mazojiRodykle} laipsniai");
            Console.WriteLine($"Kampas tarp rodykliu {kampas}");
            Console.ReadLine();
        }
    }
}
