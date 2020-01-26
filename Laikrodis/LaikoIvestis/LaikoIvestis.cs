using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laikrodis
{
    public struct LaikoIvestis
    {
        public static void PaimaVartotojoIvestaLaikaIrParodoIvestaLaika(out int minutes, out int valandos)
        {
            Console.Write("Iveskite valandas: ");
            bool successValandos = int.TryParse(Console.ReadLine(), out valandos);
            if (!successValandos)
            {
                Console.WriteLine("Neteisingai pateiktos arba nepateiktos valandos...");
                Console.WriteLine("Spauskite bet kuri mygtuka kad baigti...");
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
            bool successMinutes = int.TryParse(Console.ReadLine(), out minutes);
            if (!successMinutes)
            {
                Console.WriteLine("Neteisingai pateiktos arba nepateiktos minutes...");
                Console.Write("Spauskite bet kuri mygtuka kad baigti...");
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
            Console.WriteLine($"Ivestas laikas (hh:mm): {valandos.ToString("D2")}:{minutes.ToString("D2")}");
        }
    }
}
