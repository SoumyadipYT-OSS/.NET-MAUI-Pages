using System.Diagnostics;

namespace T01_contentType.Pages;

public partial class example1 : ContentPage
{
	public example1()
	{
		InitializeComponent();
	}

    void LoginButton_Clicked(object sender, EventArgs e) {
        Debug.WriteLine("Clicked !");
    }
}
