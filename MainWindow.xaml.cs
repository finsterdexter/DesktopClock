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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopClock
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
			if (WindowState == WindowState.Maximized)
			{
				// Use the RestoreBounds as the current values will be 0, 0 and the size of the screen
				Properties.Settings.Default.Top = RestoreBounds.Top;
				Properties.Settings.Default.Left = RestoreBounds.Left;
				Properties.Settings.Default.Height = RestoreBounds.Height;
				Properties.Settings.Default.Width = RestoreBounds.Width;
				Properties.Settings.Default.Maximized = true;
			}
			else
			{
				Properties.Settings.Default.Top = this.Top;
				Properties.Settings.Default.Left = this.Left;
				Properties.Settings.Default.Height = this.Height;
				Properties.Settings.Default.Width = this.Width;
				Properties.Settings.Default.Maximized = false;
			}
			Properties.Settings.Default.Save();
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
			this.Top = Properties.Settings.Default.Top;
			this.Left = Properties.Settings.Default.Left;
			this.Height = Properties.Settings.Default.Height;
			this.Width = Properties.Settings.Default.Width;
			// Very quick and dirty - but it does the job
			if (Properties.Settings.Default.Maximized)
			{
				WindowState = WindowState.Maximized;
			}
		}
    }
}
