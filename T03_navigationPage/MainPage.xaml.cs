namespace T03_navigationPage {
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }

        /***********************************************
         **********   EVENT HANDLERS   *****************
         ***********************************************/
        public async void GoMain(object sender, EventArgs e) {
            // Pops all pages from the stack & returns to the root page
            await Navigation.PopToRootAsync();
        }
        // method to go PageOrange.xaml under Pages folder
        private async void GoOrange(object sender, EventArgs e) {
            await Navigation.PushAsync(new Pages.PageOrange());
        }

        // method to go PageBrown.xaml under Pages folder
        private async void GoBrown(object sender, EventArgs e) {
            await Navigation.PushAsync(new Pages.PageBrown());
        }

        // method to go PagePurple.xam under Pages folder
        private async void GoPurple(object sender, EventArgs e) {
            await Navigation.PushAsync(new Pages.PagePurple());
        }
    }

}
