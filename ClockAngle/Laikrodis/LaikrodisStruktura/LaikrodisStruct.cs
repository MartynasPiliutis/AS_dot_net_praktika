using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
	public struct Laikrodis
	{
		private int _val;
		private int _min;

		public Laikrodis(int Valandos, int Minutes)
		{
			_val = Valandos;
			_min = Minutes;
		}

		public int Valandos
		{
			get { return _val; }
			set { _val = value; }
		}

		public int Minutes
		{
			get { return _min; }
			set { _min = value; }
		}
	}
}