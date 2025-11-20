using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfAppBase.ViewModels;

namespace WpfAppBase.Views
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            var view = App.ServiceProvider.GetRequiredService<SecondaryWindow>();
            ((SecondaryWindow_VM)view.DataContext).Message = "Ciao";

            view.Show();
		}
	}
}