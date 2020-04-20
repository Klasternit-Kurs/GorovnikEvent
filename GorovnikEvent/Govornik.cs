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
		public GovorArgs(string u) => govor = u;
	}

	public class Govornik
	{
		public delegate void GovorHandler(object KoSalje, GovorArgs a);
		public event GovorHandler Govor;

		public void OnGovor(string u)
		{
			Govor(this, new GovorArgs(u));
		}
	}
}
