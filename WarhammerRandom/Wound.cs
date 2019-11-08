using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerRandom
{
	public class Wound
	{
		public bool IsMortal { get; }

		public int Rend { get; }

		public Func<int> Damage { get; }
	}
}
