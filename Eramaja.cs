using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
	public class Eramaja : Hoone
	{
        public int suurus;
        public Eramaja(int pindala = 50) : base(pindala)
		{
		}
        public string Staatus
        {
            get {
                var staatus = "";
                if (suurus < 50)
                {
                    staatus = "vaike maja";
                }
                else if (suurus < 90)
                {
                    staatus = "keskmine maja";
                }
                else if (suurus < 130)
                {
                    staatus = "suur maja";
                }
                else
                {
                    staatus = "liiga suur maja";
                }
                return staatus;
            }
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Ma olen {Staatus}");
        }
    }
}
