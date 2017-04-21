using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UIKit;
using XamarinTestApp.Models;

namespace XamarinTestApp.ViewControllers
{
    public partial class AgentdasViewController : BaseViewController
    {
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
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            var agd = JsonConvert.DeserializeObject<List<AgendaEntity>>(Resources.Resources.AgendaList);
            Console.WriteLine(agd[0].Agenda);
        }
    }
}