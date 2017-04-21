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
        protected static List<string> query;

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
            query = new List<string>();
            AgdList.ToList().ForEach(x => query.Add(x.Key));

            tableView.Source = new AgendaTableSource(query, this);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }



        class AgendaTableSource : UITableViewSource
        {
            private readonly List<string> datalist;
            private UIViewController parentView;
            string CellIdentifier = "AgentdasCellIdentifier";
            public AgendaTableSource(List<string> list, AgentdasViewController vc)
            {
                datalist = list;
                parentView = vc;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
                if (cell == null)
                { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }
                string item = datalist[indexPath.Row];
                cell.TextLabel.Text = item;
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return datalist.Count();
            }
        }
    }
}