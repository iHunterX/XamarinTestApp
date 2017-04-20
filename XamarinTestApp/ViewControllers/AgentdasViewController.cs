using System;
using XamarinTestApp.ViewControllers;
using UIKit;

namespace XamarinTestApp.ViewControllers
{
    public partial class AgentdasViewController : BaseViewController
    {
        //public AgentdasViewController() : base("AgentdasViewController", null)
        //{
        //}
        public AgentdasViewController(IntPtr handle) : base (handle)
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

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            this.View.BackgroundColor = UIColor.Cyan;
        }
    }
}