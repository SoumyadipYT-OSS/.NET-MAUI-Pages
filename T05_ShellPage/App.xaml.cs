using T05_ShellPage;

namespace T05_ShellPage
{
    public partial class App : Application {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}