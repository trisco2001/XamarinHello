// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CoursesiOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel titleLabel { get; set; }

		[Action ("nextButtonTouched:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void nextButtonTouched (UIButton sender);

		[Action ("prevButtonTouched:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void prevButtonTouched (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}
		}
	}
}
