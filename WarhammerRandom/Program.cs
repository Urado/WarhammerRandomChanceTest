using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerRandom
{
	class Program
	{
		private static readonly Random rand = new Random();

		static void Main(string[] args)
		{
			var Model = new Warhammer40000ChanceTester();
			var Res = Model.SimpleTestRun();

			var Grath = Res.ReturnDeathInTestGrathDictionary();

			var Max = Grath.Max(g => g.Key);

			for (int i = 0; i <= Max; i++)
			{
				var count = Grath.ContainsKey(i) ? Grath[i] : 0;
				Console.WriteLine($"{i} {count * 100}");
			}
		}

		private static int DiceD3()
		{
			return rand.Next(1, 4);
		}

		private static int DiceD6()
		{
			return rand.Next(1, 7);
		}

		private static (int dice ,bool isSuccses) TestD6(int param, int bonus, int rerol)
		{
			var test1 = SimpleTestD6(param, bonus);
			if (!test1.isSuccses && test1.dice < rerol && test1.dice < param)
			{
				return SimpleTestD6(param, bonus);
			}
			return test1;
		}

		private static (int dice, bool isSuccses) SimpleTestD6(int param, int bonus)
		{
			var d = DiceD6();
			if (d + bonus >= param)
			{
				return (d, true);
			}
			return (d, false);
		}
	}
}
