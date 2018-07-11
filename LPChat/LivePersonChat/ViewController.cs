using System;
using ChatBinding;
using UIKit;
using Foundation;

namespace LivePersonChat
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

           NSError error = null;

            btnInit.TouchUpInside += (o, s) => {
                LPMessagingSDK.Instance.Initialize("33136087", null, out error);
                lblMsg.Text = error.ToString();
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
