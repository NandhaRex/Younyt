using Foundation;
using System;
using UIKit;

namespace Younyt
{
    public partial class HomeTabController : UITabBarController
    {
        public HomeTabController(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            tabbar.TintColor = UIColor.Black;
            tabbar.BarTintColor = UIColor.White;
            tabbar.BackgroundColor = UIColor.FromRGB(136, 136, 136);

            //UITabBar.Appearance.BarTintColor = UIColor.White;
        }
    }
}