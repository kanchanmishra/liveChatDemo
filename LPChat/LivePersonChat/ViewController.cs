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
            ChatBinding.ILPMessagingSDK lPMessagingSDK = new  LPMessagingSDK ();
            LPMessagingSDK.Instance.Initialize("33136087", LPMonitoringInitParams.New(), out error);
            btnInit.TouchUpInside += (o, s) => {
                //   LPMessagingSDK.Instance.Initialize("33136087", null, out error);
            
             //   LPMessagingSDK.Instance.Initialize("33136087", LPMonitoringInitParams.New(), out error);
              

              

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
