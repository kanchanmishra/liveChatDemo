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
           // NSError error = null;
            LPConversationViewParams viewParams;
            // Perform any additional setup after loading the view, typically from a nib.
            NSError error = null;
            bool isinitlizes =  new LPMessagingSDK().Initialize("33136087", null, out error);// new  LPMessagingSDK ();
            if(error != null)
            {
                Console.WriteLine(error.LocalizedDescription);
            } 
            else 
            {
                Console.WriteLine("Successfull initlizes");
            }

            btnInit.TouchUpInside += (o, s) => 
            {
                var conversationQuery = LPMessagingSDK.Instance.GetConversationBrandQuery("33136087", null);
                viewParams = new LPConversationViewParams(conversationQuery, this, false, null);
                LPMessagingSDK.Instance.ShowConversation(viewParams, null);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

   
}
