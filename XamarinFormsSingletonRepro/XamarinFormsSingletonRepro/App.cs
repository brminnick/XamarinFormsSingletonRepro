using System;
using Xamarin.Forms;

namespace XamarinFormsSingletonRepro
{
public class App : Application
{
    public App() => MainPage = SingletonMainPage.Instance;
}

class SingletonMainPage : ContentPage
{
    readonly static Lazy<SingletonMainPage> _instanceHolder = new Lazy<SingletonMainPage>(() => new SingletonMainPage());

    SingletonMainPage()
    {
        Content = new Label
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center,

            Text = "Main Page"
        };
    }

    public static SingletonMainPage Instance => _instanceHolder.Value;
}
}
