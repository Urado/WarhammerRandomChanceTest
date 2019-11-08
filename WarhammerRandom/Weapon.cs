using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerRandom
{
	public class Weapon
	{
		public int Atatck { get; set; }
		public int S { get; set; }
		public int Rend { get; set; }
		public Func<int> Damage { get; set; }
		public WeaponType WeaponType { get; set; }
	}

	public enum WeaponType
	{
		MeleModifyStrenge,
		MeleNotModifyStrenge,
		Pistol,
		Assault,
	}

}
