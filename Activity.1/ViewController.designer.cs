// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Activity
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButtonCell CheckboxOutlet { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell EmailOutlet { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell NameOutlet { get; set; }

		[Action ("SubmintBtnAction:")]
		partial void SubmintBtnAction (AppKit.NSButtonCell sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CheckboxOutlet != null) {
				CheckboxOutlet.Dispose ();
				CheckboxOutlet = null;
			}

			if (EmailOutlet != null) {
				EmailOutlet.Dispose ();
				EmailOutlet = null;
			}

			if (NameOutlet != null) {
				NameOutlet.Dispose ();
				NameOutlet = null;
			}
		}
	}
}
