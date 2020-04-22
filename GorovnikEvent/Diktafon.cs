using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GorovnikEvent
{
	public class Diktafon
	{
		public ObservableCollection<string> SveReceno = new ObservableCollection<string>();

		public void Snimi(object sender, GovorArgs a)
		{
			SveReceno.Add($"{a.vreme} - {a.govornik}: {a.govor}");
		}

		public void SnimiUfajl(object sender, GovorArgs a)
		{
			File.WriteAllLines(a.govornik, SveReceno);
		}
	}
}
