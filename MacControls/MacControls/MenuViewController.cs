// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace MacControls
{
	public partial class MenuViewController : NSViewController
	{
		#region Constructors
		public MenuViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void ViewWillAppear ()
		{
			base.ViewWillAppear ();
		}
		#endregion

		#region Actions
		partial void ItemOne (Foundation.NSObject sender) {
			DropDownSelected.Title = "Item 1";
			FeedbackLabel.StringValue = "Item One Selected";
		}

		partial void ItemTwo (Foundation.NSObject sender) {
			DropDownSelected.Title = "Item 2";
			FeedbackLabel.StringValue = "Item Two Selected";
		}

		partial void ItemThree (Foundation.NSObject sender) {
			DropDownSelected.Title = "Item 3";
			FeedbackLabel.StringValue = "Item Three Selected";
		}
		#endregion
	}
}
