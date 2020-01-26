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
            Laikrodis IvestasLaikas = LaikrodisTimeSet.PaimaVartotojoIvestaLaikaIrParodoKonsoleje();
            LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(IvestasLaikas.Valandos, IvestasLaikas.Minutes);
            Console.ReadLine();
        }
    }
}
