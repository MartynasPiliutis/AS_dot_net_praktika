using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
    public struct KampoSkaiciavimas
    {
        public static void PaskaiciuojaIrIsvedaIKonsoleKampaTarpRodykliu(int minutes, int valandos)
        {
            double kampas;
            char deg = Convert.ToChar(176);

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
            if (minutes % 2 != 0)
            {
                Console.WriteLine($"Kampas tarp rodykliu yra {kampas - 0.5}{deg}30'({kampas}{deg})");
            }
            else
            {
                Console.WriteLine($"Kampas tarp rodykliu yra {kampas}{deg}");
            }
        }
    }
}
