using T02_FlyoutType.Pages;

namespace T02_FlyoutType {
    public partial class MainPage : FlyoutPage {

        public MainPage() {
            try {
                InitializeComponent();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            if (flyoutPage?.collectionView != null) {
                flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
            } else {
                Console.WriteLine("flyoutPage or collectionView is null");
            }
        }



        void OnSelectionChanged(object? sender, SelectionChangedEventArgs e) {
            var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
            if (item != null && item.TargetType != null) {
                var pageInstance = Activator.CreateInstance(item.TargetType) as Page;
                if (pageInstance != null) {
                    Detail = new NavigationPage(pageInstance);
                    if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                        IsPresented = false;
                }
            }
        }
    }

}
