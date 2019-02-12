using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using Younyt.Custom_Class;
using Younyt.Model;

namespace Younyt
{
    public partial class HomeViewController : UIViewController
    {
        public HomeViewController(IntPtr handle) : base(handle)
        {
        }
        public HomeViewController()
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var gradient = CustomControls.ButtonBackground(homeHeading);
            homeHeading.Layer.InsertSublayer(gradient, 0);

            homeHeadingLabel.Text = "Now ->";

            var tableItems = new List<AvatarDetails>()
            {
                new AvatarDetails { AvatarCompany = "kumar@gmail.com", AvatarName = "Kumar D" },
                new AvatarDetails { AvatarCompany = "avzdf@gmail.com", AvatarName = "Vivek S" }
            };
            homeTableView.Source = new TableSource(tableItems);

        }
    }
}