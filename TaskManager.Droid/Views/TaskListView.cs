using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace TaskManager.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class TaskListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TaskListView);
        }
    }
}