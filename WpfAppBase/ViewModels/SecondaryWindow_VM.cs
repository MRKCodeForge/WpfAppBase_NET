using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfAppBase.ViewModels
{
	public partial class SecondaryWindow_VM : ObservableRecipient
	{
		[ObservableProperty]
		private string _message;
	}
}
