// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace MacImages
{
	public partial class PictureViewController : NSViewController
	{
		#region Computed Properties
		public NSImage Picture { get; set; } = null;
		#endregion

		#region Constructors
		public PictureViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Initialize
			PictureView.Image = Picture;
		}
		#endregion
	}
}
