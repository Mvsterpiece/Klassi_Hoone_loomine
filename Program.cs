using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
	static class Program
	{
		static void Main(string[] args)
		{
			Eramaja majake = new Eramaja();
			Inimene mees = new Inimene("Juku");
			majake.uks = new Uks("must");
			mees.hoone = majake;
			mees.NaitaInfo();





			Console.ReadLine();
		}
	}
}
