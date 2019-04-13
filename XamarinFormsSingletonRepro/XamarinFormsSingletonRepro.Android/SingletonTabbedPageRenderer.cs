using Xamarin.Forms;

using Android.Content;

using XamarinFormsSingletonRepro;
using XamarinFormsSingletonRepro.Droid;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(SingletonTabbedPage), typeof(SingletonTabbedPageRenderer))]
namespace XamarinFormsSingletonRepro.Droid
{
    public class SingletonTabbedPageRenderer : TabbedPageRenderer
    {
        public SingletonTabbedPageRenderer(Context context) : base(context)
        {
        }
    }
}
