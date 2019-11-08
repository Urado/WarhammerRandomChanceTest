using System;

namespace WarhammerRandom
{
	static class DiceTools
	{
		private static readonly Random rand = new Random();
		public static int DiceD3()
		{
			return rand.Next(1, 4);
		}

		public static int DiceD6()
		{
			return rand.Next(1, 7);
		}

		public static (int dice, bool isSuccses) TestD6(int param, int bonus, int rerol)
		{
			var test1 = SimpleTestD6(param, bonus);
			if (!test1.isSuccses && test1.dice < rerol && test1.dice < param)
			{
				return SimpleTestD6(param, bonus);
			}
			return test1;
		}

		public static (int dice, bool isSuccses) SimpleTestD6(int param, int bonus)
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
