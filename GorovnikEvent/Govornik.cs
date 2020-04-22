using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorovnikEvent
{
	public class GovorArgs
	{
		public string govor;
		public string govornik;
		public DateTime vreme = DateTime.Now;

		public GovorArgs(string u, string g)
		{
			govor = u;
			govornik = g;
		}
	}

	public class Govornik
	{
		public delegate void GovorHandler(object KoSalje, GovorArgs a);
		public event GovorHandler Govor;
		public string Ime { get; set; }

		public void OnGovor(string u)
		{
			Govor(this, new GovorArgs(u, Ime));
		}
	}
}
