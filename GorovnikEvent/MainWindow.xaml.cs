using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GorovnikEvent
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string unos;
		public string Unos
		{
			get => unos;
			set
			{
				unos = value;
				g1.OnGovor(unos);
			}
		}

		public Govornik g1 = new Govornik();

		ObservableCollection<Slusaoc> sls = new ObservableCollection<Slusaoc>();
		Diktafon d = new Diktafon();

		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;
			sls.Add(new Slusaoc("Pera"));
			sls.Add(new Slusaoc("Pera"));
			sls.Add(new Slusaoc("Pera"));
			sls.Add(new Slusaoc("Pera"));
			sls.Add(new Slusaoc("Pera"));
			sls.Add(new Slusaoc("Pera"));

			dg.ItemsSource = sls;

			g1.Govor += d.Snimi;

		}

		private void Klik(object sender, RoutedEventArgs e)
		{
			var chk = sender as CheckBox;
			if (chk.IsChecked == true)
			{
				g1.Govor += ((sender as CheckBox).DataContext as Slusaoc).Slusaj;
			} else
			{
				g1.Govor -= ((sender as CheckBox).DataContext as Slusaoc).Slusaj;
			}
		}

		private void dugme(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(sender.ToString());
		}
	}
}
