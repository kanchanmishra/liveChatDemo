// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace LivePersonChat
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnInit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblMsg { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnInit != null) {
                btnInit.Dispose ();
                btnInit = null;
            }

            if (lblMsg != null) {
                lblMsg.Dispose ();
                lblMsg = null;
            }
        }
    }
}