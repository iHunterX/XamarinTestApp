using Foundation;
using System;
using System.Runtime.InteropServices;
using UIKit;

namespace XamarinTestApp
{
    public partial class MenuCell : UITableViewCell
    {
        public MenuCell (IntPtr handle) : base (handle)
        {
        }

        public void SetUpCell([Optional]UIImage img, string label)
        {
            if (titleImage != null) titleImage.Image = img;
            if (titleLable != null) titleLable.Text  = label;
        }
    }
}