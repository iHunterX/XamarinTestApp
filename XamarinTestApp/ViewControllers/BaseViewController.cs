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
            NavigationItem.Title = Title;
            NavigationItem.SetLeftBarButtonItem(
                new UIBarButtonItem(UIImage.FromBundle("threelines")
                    , UIBarButtonItemStyle.Plain
                    , (sender, args) => {
                        SidebarController.ToggleMenu();
                    }), true);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            Console.WriteLine("NavigationItem.Title ->>" + NavigationItem.Title);
            Console.WriteLine("NavigationItem ->>" + NavController.NavigationItem.Title);
            Console.WriteLine("This.Title->> " + Title);
            
        }
    }
}