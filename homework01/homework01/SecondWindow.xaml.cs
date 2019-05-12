using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace homework01
{
	/// <summary>
	/// Interaction logic for SecondWindow.xaml
	/// </summary>
	public partial class SecondWindow : Window
	{
		public SecondWindow()
		{
			InitializeComponent();

			var users = new List<Models.User>();

			users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
			users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });
			users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });

			uxList.ItemsSource = users;
		}

		private void uxList_OnColumnHeaderClick(object sender, RoutedEventArgs e)
		{
			GridViewColumnHeader column = (sender as GridViewColumnHeader);
			string sortBy = column.Tag.ToString();

			uxList.Items.SortDescriptions.Clear();
			uxList.Items.SortDescriptions.Add(new SortDescription(sortBy, ListSortDirection.Ascending));
		}
	}
}
