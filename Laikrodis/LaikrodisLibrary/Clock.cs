using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
    public struct Valandos
    {
        private int _h;
        private int _mins;
        public int LaikasValandos
        {
            get { return _h; }
            set { _h = value; }
        }
        public int LaikasMinutes
        {
            get { return _mins; }
            set { _mins = value; }
        }
        public static Valandos NaujasisLaikasIvedamasIStruktura(int minutes, int valandos)
        {
            Valandos NaujasLaikas = new Valandos();
            NaujasLaikas.LaikasValandos = valandos;
            NaujasLaikas.LaikasMinutes = minutes;
            return NaujasLaikas;
        }
    }
}
