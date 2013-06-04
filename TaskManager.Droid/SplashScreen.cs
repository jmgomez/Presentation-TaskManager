using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace TaskManager.Droid
{
    [Activity(Label = "TaskManager.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}