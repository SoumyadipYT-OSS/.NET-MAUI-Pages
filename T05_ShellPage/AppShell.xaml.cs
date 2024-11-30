using Microsoft.Maui.Controls;
using T05_ShellPage.Views;

namespace T05_ShellPage {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            // Register routes for navigation
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(NewsPage), typeof(NewsPage));
            Routing.RegisterRoute(nameof(SupportPage), typeof(SupportPage));
        }
    }
}