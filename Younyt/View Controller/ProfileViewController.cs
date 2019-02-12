using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class ProfileViewController : UIViewController
    {
        public ProfileViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var gradient = CustomControls.ButtonBackground(profileLabelView);
            profileLabelView.Layer.InsertSublayer(gradient, 0);
            profileLabel.Text = "Profile";
        }
    }
}