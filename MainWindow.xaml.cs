using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AngelSix_Directory {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {


		#region constructor
		/// <summary>
		/// Defult Constructor
		/// </summary>
		public MainWindow() {
			InitializeComponent();
		}
		#endregion


		#region methods
		/// <summary>
		/// When the application first opens
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Loaded( object sender, RoutedEventArgs e ) {
			foreach( var drive in Directory.GetLogicalDrives() ) {
				var item = new TreeViewItem();
				FolderView.Items.Add(item);
				item.Header = drive;
			}
		}

		#endregion

	}
}
