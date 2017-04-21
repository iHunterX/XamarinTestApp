using System;

using UIKit;

namespace XamarinTestApp.ViewControllers
{
    public partial class AgendasNewList : AgentdasViewController
    {
        public AgendasNewList(IntPtr handle) : base (handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}