using System;
using System.Runtime.InteropServices;
using UIKit;

namespace XamarinTestApp.Cells
{
    public partial class MenuCell : UITableViewCell
    {
        public MenuCell (IntPtr handle) : base (handle)
        {
        }

        public void SetUpCell([Optional]string strImg, string label)
        {
            if (titleImage != null) titleImage.Image = UIImage.FromBundle(strImg); ;
            if (titleLable != null) titleLable.Text  = label;
        }
    }
}