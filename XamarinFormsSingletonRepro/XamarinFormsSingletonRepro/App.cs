using System;
using Xamarin.Forms;

namespace XamarinFormsSingletonRepro
{
    public class App : Application
    {
        public App() => MainPage = SingletonTabbedPage.Instance;
    }

    public class SingletonTabbedPage : TabbedPage
    {
        readonly static Lazy<SingletonTabbedPage> _instanceHolder = new Lazy<SingletonTabbedPage>(() => new SingletonTabbedPage());

        public static SingletonTabbedPage Instance => _instanceHolder.Value;
    }
}
