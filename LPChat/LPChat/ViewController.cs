using System;

using UIKit;
using BusinessChat;
using ChatBinding;
using Foundation;


namespace LPChat
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


            LPMessagingSDK.Instance.Initialize("33136087", null, out error);
            lblMsg.Text = error.ToString();




           //LPMessagingSDK.instance.initialize("Your account ID")
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
