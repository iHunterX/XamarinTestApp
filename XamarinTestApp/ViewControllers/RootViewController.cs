using System;
using System.Diagnostics.CodeAnalysis;
using UIKit;

namespace XamarinTestApp.ViewControllers
{
    [SuppressMessage("ReSharper", "RedundantOverridenMember")]
    public partial class RootViewController : UIViewController
    {
        private UIStoryboard _storyboard;


        // the sidebar controller for the app
        public SidebarNavigation.SidebarController SidebarController { get; private set; }

        // the navigation controller
        public CustomNavigationController NavController { get; private set; }

        // the storyboard
        public override UIStoryboard Storyboard => _storyboard ?? (_storyboard = UIStoryboard.FromName("Main", null));

        public RootViewController() : base(null, bundle: null)
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

            var agentdasVC = (AgentdasViewController)Storyboard.InstantiateViewController("AgentdasViewController");
            var draftsVC = (DraftsViewController)Storyboard.InstantiateViewController("DraftsViewController");
            //var draftsVC = (DraftsViewController)Storyboard.InstantiateViewController("DraftsViewController");

            // create a slideout navigation controller with the top navigation controller and the menu view controller
            NavController = new CustomNavigationController();
            //NavController.PushViewController(introController, false);
            SidebarController = new SidebarNavigation.SidebarController(this, NavController, agentdasVC) { 
                MenuWidth = 220,
                ReopenOnRotate = false
            };


        }
    }
}