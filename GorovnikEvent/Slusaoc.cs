using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorovnikEvent
{
	public class Slusaoc : INotifyPropertyChanged
	{
		public string Ime { get; set; }
		private string info;
		public string Info
		{
			get => info;
			set
			{
				info = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Info"));
			}
		}

		public void Slusaj(object koSalje, GovorArgs a)
		{
			Info = a.govor;
		}

		public Slusaoc(string i) => Ime = i;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
