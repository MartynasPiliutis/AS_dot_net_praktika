using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laikrodis;


namespace Laikrodis
{
    class Program
    {
        static void Main(string[] args)
        {
            LaikoIvestis.PaimaVartotojoIvestaLaika(out int minutes, out int valandos);
            Valandos.PriskiriameLaikaStrukturai(minutes, valandos);
            KampoSkaiciavimas.PaskaiciuojaIrIsvedaIKonsoleKampaTarpRodykliu(minutes, valandos);
            Console.ReadLine();
        }
    }
}
