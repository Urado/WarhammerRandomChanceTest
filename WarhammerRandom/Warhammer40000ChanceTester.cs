using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerRandom
{
	public class Warhammer40000ChanceTester
	{
		public Unit AtakerUnit { get; set; }
		public Unit TargetUnit { get; set; }
		public int IterCount{ get; set; } = 100000;


		public DeathInTestGrath SimpleTestRun()
		{
			var res = new DeathInTestGrath();
			for (int a = 0; a < IterCount; a++)
			{
				var countAtack = DiceTools.DiceD6()+ DiceTools.DiceD6()+ DiceTools.DiceD6()+ DiceTools.DiceD6();//20;//2 + DiceD3();//DiceD3() + DiceD3() + DiceD3() + DiceD3();
				int sucsessCount = 0;
				for (int i = 0; i < countAtack; i++)
				{
					var bTest = DiceTools.TestD6(3, 0, 1);
					if (bTest.isSuccses)
					{
						var wTest = DiceTools.TestD6(2, 0, 1);
						if (wTest.isSuccses)
						{
							var sTest = DiceTools.TestD6(6, 0, 0);
							if (!sTest.isSuccses)
							{
								//var wound = DiceTools.DiceD6();
								//for (int w = 0; w < wound; w++)
								//{
								//	var fnpTest = DiceTools.TestD6(7, 0, 0);
								//	if (!fnpTest.isSuccses)
								//	{
								sucsessCount += 1;//DiceTools.DiceD6();
								//	}
								//}
							}
						}
					}
				}
				res.AddSingleTestResult(sucsessCount);
			}
			return res;
		}
	}
}


