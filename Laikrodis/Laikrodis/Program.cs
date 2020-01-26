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
            int minutes;
            int valandos;
            decimal mazojiRodykle;
            decimal didziojiRodykle;
            decimal kampas;
            Console.Write("Iveskite valandas: ");
            bool successValandos = Int32.TryParse(Console.ReadLine(), out valandos);
            if (!successValandos)
            {
                Console.WriteLine("Neteisingai pateiktos valandos...");
                Console.WriteLine("Spauskite bet kuri kad baigti...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (valandos > 23 || valandos < 0)
            {
                Console.WriteLine($"Neteisingai pateiktos valandos: {valandos}");
                Console.WriteLine("Spauskite bet kuri kad baigti...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Iveskite minutes: ");
            bool successMinutes = Int32.TryParse(Console.ReadLine(), out minutes);
            if (!successMinutes)
            {
                Console.WriteLine("Neteisingai pateiktos valandos: {0}", minutes);
                Console.Write("Spauskite bet kuri kad baigti...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (minutes > 59 || minutes < 0)
            {
                Console.WriteLine($"Neteisingai pateiktos minutes: {minutes}");
                Console.WriteLine("Spauskite bet kuri kad baigti...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine($"Ivestas laikas yra {valandos.ToString("D2")}:{minutes.ToString("D2")}");
            Console.ReadLine();
            if (valandos > 12)
            {
                valandos -= 12;
            }
            didziojiRodykle = 6 * minutes;
            mazojiRodykle = 30 * valandos + 0.50m * minutes;
            kampas = mazojiRodykle - didziojiRodykle;
            if (kampas > 180)
            {
                kampas -= 360;
            }
            if (kampas < 0)
            {
                kampas *= -1;
            }
            Console.WriteLine($"Kampas tarp rodykliu yra {kampas}");
            Console.ReadLine();
        }
    }
}
