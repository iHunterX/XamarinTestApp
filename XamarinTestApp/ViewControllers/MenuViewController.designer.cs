﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinTestApp.ViewControllers
{
    [Register ("MenuViewController")]
    partial class MenuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView menuList { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sideBarTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (menuList != null) {
                menuList.Dispose ();
                menuList = null;
            }

            if (sideBarTitle != null) {
                sideBarTitle.Dispose ();
                sideBarTitle = null;
            }
        }
    }
}