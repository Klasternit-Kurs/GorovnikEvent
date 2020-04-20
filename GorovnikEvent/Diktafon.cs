using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorovnikEvent
{
	public class Diktafon
	{
		public List<string> SveReceno = new List<string>();

		public void Snimi(object sender, GovorArgs a)
		{
			SveReceno.Add(a.govor);
		}
	}
}
