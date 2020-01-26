using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
    public class LaikrodisTimeSet
    {
        public static Laikrodis PaimaVartotojoIvestaLaikaIrParodoKonsoleje()
        {
            Console.Write("Iveskite valandas: ");
            bool successValandos = int.TryParse(Console.ReadLine(), out int valandos);
            if (!successValandos || valandos > 23 || valandos < 0)
            {
                PranesaKadGautasNeteisingasArgumentasProgramaNutraukiama();
            }

            Console.Write("Iveskite minutes: ");
            bool successMinutes = int.TryParse(Console.ReadLine(), out int minutes);
            if (!successMinutes || minutes > 59 || minutes < 0)
            {
                PranesaKadGautasNeteisingasArgumentasProgramaNutraukiama();
            }

            Laikrodis IvestasLaikas = new Laikrodis();
            IvestasLaikas = new Laikrodis(valandos, minutes);
            Console.WriteLine($"Ivestas laikas (hh:mm): {IvestasLaikas.Valandos.ToString("D2")}:{IvestasLaikas.Minutes.ToString("D2")}");
            return IvestasLaikas;
        }

        private static void PranesaKadGautasNeteisingasArgumentasProgramaNutraukiama()
        {
            Console.WriteLine($"Neivesta, arba ivesta neteisinga kintamojo reiksme...");
            Console.WriteLine("Spauskite bet kuri mygtuka kad baigti...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}