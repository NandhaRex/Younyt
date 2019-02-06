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
            var gradientLayer = CustomControls.ButtonBackground(EditProfileButton);
            EditProfileButton.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}