﻿using System;

using UIKit;

namespace XamarinTestApp.ViewControllers
{
    public partial class BaseViewController : UIViewController
    {
        protected SidebarNavigation.SidebarController SidebarController => (UIApplication.SharedApplication.Delegate as AppDelegate)?.RootViewController.SidebarController;

        // provide access to the navigation controller to all inheriting controllers
        protected CustomNavigationController NavController => (UIApplication.SharedApplication.Delegate as AppDelegate)?.RootViewController.NavController;

        // provide access to the storyboard to all inheriting controllers
        public override UIStoryboard Storyboard => (UIApplication.SharedApplication.Delegate as AppDelegate)?.RootViewController.Storyboard;

        public BaseViewController(IntPtr handle) : base (handle)
		{
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationItem.SetLeftBarButtonItem(
                new UIBarButtonItem(UIImage.FromBundle("threelines")
                    , UIBarButtonItemStyle.Plain
                    , (sender, args) => {
                        SidebarController.ToggleMenu();
                    }), true);
        }
    }
}