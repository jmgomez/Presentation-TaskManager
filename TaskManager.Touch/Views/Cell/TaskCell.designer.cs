// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TaskManager.Touch
{
	[Register ("TaskCell")]
	partial class TaskCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel LabelName { get; set; }
		 
		[Outlet]
		MonoTouch.UIKit.UISwitch SwitchComplete { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelName != null) {
				LabelName.Dispose ();
				LabelName = null;
			}

			if (SwitchComplete != null) {
				SwitchComplete.Dispose ();
				SwitchComplete = null;
			}
		}
	}
}
