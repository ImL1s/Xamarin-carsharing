using Prism.Unity;
using CarSharing.Views;
using Xamarin.Forms;
using Prism.Navigation;

namespace CarSharing
{
    public partial class App : PrismApplication
    {
        private static App _instance;

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        public INavigationService Navigator
        {
            get
            {
                return NavigationService;
            }
        }

        public static App Instance
        {
            get
            {
                return _instance;
            }
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            _instance = this;

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
            //NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MainTabPage>();
        }
    }
}
