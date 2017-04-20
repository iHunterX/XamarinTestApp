using System;
using System.Diagnostics.CodeAnalysis;
using UIKit;

namespace XamarinTestApp.ViewControllers
{
    [SuppressMessage("ReSharper", "RedundantOverridenMember")]
    public partial class MenuViewController : BaseViewController
    {
        public MenuViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}