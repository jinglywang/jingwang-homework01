using System;
using System.Collections.Generic;
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

namespace homework01
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void uxUserName_TextChanged(object sender, TextChangedEventArgs e)
		{
			onUserNamePasswordTextChanged();
		}

		private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
		{
			onUserNamePasswordTextChanged();
			
		}

		private void onUserNamePasswordTextChanged()
		{
			if (uxUserName.Text != "" && uxPassword.Text != "")
			{
				btnSubmit.IsEnabled = true;
			}
			else
			{
				btnSubmit.IsEnabled = false;
		    }
		}
	}
}
