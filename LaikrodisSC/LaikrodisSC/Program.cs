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
            int valandos;
            int minutes;
            double kampas;
            char deg = Convert.ToChar(176);

            Console.Write("Iveskite valandas: ");
            bool successValandos = int.TryParse(Console.ReadLine(), out valandos);
            if (!successValandos || valandos > 23 || valandos < 0)
            {
                PranesaKadGautasNeteisingasArgumentasProgramaNutraukiama();
            }

            Console.Write("Iveskite minutes: ");
            bool successMinutes = int.TryParse(Console.ReadLine(), out minutes);
            if (!successMinutes || minutes > 59 || minutes < 0)
            {
                PranesaKadGautasNeteisingasArgumentasProgramaNutraukiama();
            }
            
            Console.WriteLine($"Ivestas laikas (hh:mm): {valandos.ToString("D2")}:{minutes.ToString("D2")}");
            kampas = PaskaiciuojaMazesniKampaTarDidziosiosirMazosiosLaikrodzioRodykles(ref valandos, minutes);
            PateikiaGalutiniRezultataIKonsole(minutes, kampas, deg);
            Console.ReadLine();
        }

        private static void PateikiaGalutiniRezultataIKonsole(int minutes, double kampas, char deg)
        {
            if (minutes % 2 != 0)
            {
                Console.WriteLine($"Kampas tarp rodykliu yra {kampas - 0.5}{deg}30'({kampas}{deg})");
            }
            else
            {
                Console.WriteLine($"Kampas tarp rodykliu yra {kampas}{deg}");
            }
        }

        private static double PaskaiciuojaMazesniKampaTarDidziosiosirMazosiosLaikrodzioRodykles(ref int valandos, int minutes)
        {
            double kampas;
            if (valandos > 12)
            {
                valandos -= 12;
            }
            kampas = (30 * valandos - 5.5 * minutes);
            if (kampas > 180)
            {
                kampas = 360 - kampas;
            }
            else if (kampas < 0)
            {
                if (kampas < -180)
                {
                    kampas += 360;
                }
                else
                {
                    kampas *= -1;
                }
            }

            return kampas;
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
