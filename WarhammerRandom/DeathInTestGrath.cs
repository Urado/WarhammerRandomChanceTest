using System.Collections.Generic;
using System.Linq;

namespace WarhammerRandom
{
	public class DeathInTestGrath
	{
		private Dictionary<int, int> woundDeath;

		private int countTest;

		public DeathInTestGrath()
		{
			countTest = 0;
			woundDeath = new Dictionary<int, int>();
		}

		public void AddSingleTestResult(int countWound)
		{
			countTest++;
			if (woundDeath.ContainsKey(countWound))
				woundDeath[countWound]++;
			else
				woundDeath[countWound] = 1;
		}

		public IDictionary<int, double> ReturnDeathInTestGrathDictionary()
		{
			return woundDeath.Select(d => new KeyValuePair<int, double>(d.Key, d.Value/(double)countTest)).ToDictionary(p=>p.Key,p=>p.Value);
		}
	}
}
