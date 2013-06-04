using System;
using System.Drawing;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TaskManager.Core.Model;
namespace TaskManager.Touch
{
	public partial class TaskCell : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("TaskCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("TaskCell");

		public TaskCell (IntPtr handle) : base (handle)
		{
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<TaskCell, Task>();
                set.Bind(this.LabelName).To(task => task.Name);
                set.Bind(this.SwitchComplete).To(task => task.Complete);
                set.Apply();
            });
		}

		public static TaskCell Create ()
		{
			return (TaskCell)Nib.Instantiate (null, null) [0];
		}
	}
}

