﻿using System;
using System.Diagnostics.CodeAnalysis;
using Foundation;
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
            var agentdasVc = (AgentdasViewController)Storyboard.InstantiateViewController("AgentdasViewController");
            var draftsVc = (DraftsViewController)Storyboard.InstantiateViewController("DraftsViewController");
            UIViewController[] listControllers = { agentdasVc,draftsVc };
            if (menuList != null)
            menuList.Source = new MyListSource(listControllers, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        class MyListSource : UITableViewSource
        {
            MenuViewController _menuView;
            UIViewController[] _listVc;
            readonly string CellIdentifier = "menuCellIdentifier";
            public MyListSource(UIViewController[] listControllers, MenuViewController menu)
            {
                _listVc = listControllers;
                _menuView = menu;
            }


            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var item = _listVc[indexPath.Row].Title;

                //---- if there are no cells to reuse, create a new one
                MenuCell cell = (MenuCell)tableView.DequeueReusableCell(CellIdentifier);
                cell.SetUpCell(null,item);
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return _listVc.Length;
            }

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                var vc = _listVc[indexPath.Row];
                if (Equals(vc, _menuView.NavController.TopViewController))
                {
                    _menuView.SidebarController.CloseMenu();
                }

                tableView.DeselectRow(indexPath, true);

                _menuView.SidebarController.ChangeContentView(vc);

                _menuView.SidebarController.CloseMenu();
            }
        }
        
    }
}