// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TaskManager.Touch
{
	[Register ("TaskListView")]
	partial class TaskListView
	{
		[Outlet]
		MonoTouch.UIKit.UITableView TableView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TextFieldAdd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonAdd { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonAll { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonFinished { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ButtonUnfinished { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}

			if (TextFieldAdd != null) {
				TextFieldAdd.Dispose ();
				TextFieldAdd = null;
			}

			if (ButtonAdd != null) {
				ButtonAdd.Dispose ();
				ButtonAdd = null;
			}

			if (ButtonAll != null) {
				ButtonAll.Dispose ();
				ButtonAll = null;
			}

			if (ButtonFinished != null) {
				ButtonFinished.Dispose ();
				ButtonFinished = null;
			}

			if (ButtonUnfinished != null) {
				ButtonUnfinished.Dispose ();
				ButtonUnfinished = null;
			}
		}
	}
}
