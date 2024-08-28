using System.Windows.Input;

namespace T01_contentType.Pages;

public partial class example2 : ContentPage
{ 
	public ICommand OpenUrlCommand { get; }

	public example2()
	{
		InitializeComponent();
		OpenUrlCommand = new Command<string>(OpenUrl);
    }

	private async void OpenUrl(string url) {
		if (Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
			await Browser.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
		}
	}

}