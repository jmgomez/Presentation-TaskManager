using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Views;
using TaskManager.Core.ViewModels;

namespace TaskManager.Touch
{
	public partial class TaskListView : MvxViewController
	{
		public TaskListView () : base ("TaskListView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var source = new MvxSimpleTableViewSource(TableView, TaskCell.Key, TaskCell.Key);
			TableView.Source = source;
            
		   
           
			var set = this.CreateBindingSet<TaskListView, TaskListViewModel>();   
            set.Bind(TextFieldAdd).To(vm => vm.NewTaskText).TwoWay();
            set.Bind(ButtonAdd).To(vm => vm.AddTaskCommand);
			set.Bind(ButtonAll).To(vm => vm.ShowAllTasksCommand);
			set.Bind(ButtonFinished).To(vm => vm.ShowFinishedTasksCommand);
			set.Bind(ButtonUnfinished).To(vm => vm.ShowUnfinishedTasksCommand);
            set.Bind(source).To(vm => vm.Tasks);
			set.Apply();
			TableView.ReloadData();
            this.ButtonAdd.TouchUpInside += (sender, e) => this.View.EndEditing(true);
		}
	}
}

