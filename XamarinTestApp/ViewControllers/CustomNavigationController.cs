using UIKit;

// ReSharper disable All

namespace XamarinTestApp.ViewControllers
{
    public partial class CustomNavigationController : UINavigationController
    {
        public CustomNavigationController() : base((string) null, null)
        {
        }

        // ReSharper disable once RedundantOverridenMember
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