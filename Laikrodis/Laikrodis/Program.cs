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
            LaikoIvestis.PaimaVartotojoIvestaLaikaIrParodoIvestaLaika(out int minutes, out int valandos);
            Valandos NaujasLaikas = Valandos.NaujasisLaikasIvedamasIStruktura(minutes, valandos);
            KampoSkaiciavimas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(NaujasLaikas.LaikasMinutes, NaujasLaikas.LaikasValandos);
            Console.ReadLine();
        }
    }
}
