namespace T01_contentType {
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }

        // method to go example1.xaml page under Pages folder
        private async void GoExample1(object sender, EventArgs e) {
            await Navigation.PushAsync(new Pages.example1());
        }

        // method to go example2.xaml page under Pages folder
        private async void GoExample2(object sender, EventArgs e) {
            await Navigation.PushAsync(new Pages.example2());
        }
    }

}
