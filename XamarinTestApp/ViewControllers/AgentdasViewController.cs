using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CoreFoundation;
using Foundation;
using UIKit;
using XamarinTestApp.Models;
using static Newtonsoft.Json.JsonConvert;

namespace XamarinTestApp.ViewControllers
{
    public partial class AgentdasViewController : BaseViewController
    {
        private IEnumerable<IGrouping<string, AgendaEntity>> AgdList { get; set; }


        protected static List<string> Query { get; private set; }



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
            NavigationItem.SetRightBarButtonItem(
                new UIBarButtonItem(UIImage.FromBundle("threelines")
                    , UIBarButtonItemStyle.Plain
                    , (sender, args) => {
                        SidebarController.ToggleMenu();
                    }), true);

            AgdList = DeserializeObject<List<AgendaEntity>>(Resources.Resources.AgendaList).ToList().GroupBy(x => x.Agenda);
            Query = new List<string>();
            AgdList.ToList().ForEach(x => Query.Add(x.Key));
            tableView.Source = new AgendaTableSource(Query, this);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }



        class AgendaTableSource : UITableViewSource
        {
            private readonly List<string> _datalist;
            private UIViewController _parentView;
            string CellIdentifier = "AgentdasCellIdentifier";
            public AgendaTableSource(List<string> list, AgentdasViewController vc)
            {
                _datalist = list;
                _parentView = vc;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier) ?? new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
                string item = _datalist[indexPath.Row];
                cell.TextLabel.Text = item;
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return _datalist.Count();
            }
        }
    }
}