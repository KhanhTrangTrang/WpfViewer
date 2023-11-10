using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace GrapeCity.ActiveReports.Samples.WPFViewer
{
	/// <summary>
	/// 
	/// </summary>
	public partial class MainWindow : Window
	{
		static readonly string CurrentFileLocation = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Catalog.rdlx";

		public MainWindow()
		{
			InitializeComponent();
            ReportViewer.LoadDocument(CurrentFileLocation);
        }
	}
}
