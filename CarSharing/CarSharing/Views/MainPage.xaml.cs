using Prism.Unity;
using System.Reactive.Linq;
using System;
using Xamarin.Forms;
using System.Reactive.Concurrency;
using System.Threading;

namespace CarSharing.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Observable.FromEventPattern(ev => loginButton.Clicked += ev, ev => loginButton.Clicked -= ev)
                .Throttle(TimeSpan.FromMilliseconds(500))
                .ObserveOn(SynchronizationContext.Current)
                .SubscribeOn(SynchronizationContext.Current)
                .Subscribe(x =>
                {
                    App.Instance.Navigator.NavigateAsync("NavigationPage/MainTabPage?Title=Hello%20from%20Xamarin.Forms");
                });
            //loginButton.Clicked += (sender, e) => {
            //    //Navigation.PushModalAsync(new MainTabPage());
            //    App.Instance.Navigator.NavigateAsync("NavigationPage/MainTabPage?Title=Hello%20from%20Xamarin.Forms");
            //};
        }
    }
}
