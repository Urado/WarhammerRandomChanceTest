using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerRandom
{
	public class Model
	{
		public Model(int ws, int bs, int s, int t, int w, int a, int ld, int sv, int invSv, int fnp)
		{
			WS = ws;
			BS = bs;
			S = s;
			T = t;
			W = w;
			A = a;
			Ld = ld;
			Sv = sv;
			InvSv = invSv;
			Fnp = fnp;
			LostW = 0;
		}

		public int WS { get; }
		public int BS { get; }
		public int S { get; }
		public int T { get; }
		public int W { get;  }
		public int LostW { get; private set; }
		public int A { get; }
		public int Ld { get; }
		public int Sv { get; }
		public int InvSv { get; }

		public int Fnp { get; }

		public bool SaveFromWound(Wound wound)
		{
			var save = Math.Min(Sv + wound.Rend, InvSv);
			var (dice, isSuccses) = DiceTools.TestD6(save, 0, 7);
			if (!isSuccses)
			{
				var damage = wound.Damage();
				LostW += damage;
				return W > LostW;
			}
			return true;
		}
	}
}
