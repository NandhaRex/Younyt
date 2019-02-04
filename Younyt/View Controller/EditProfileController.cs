using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class EditProfileController : UIViewController
    {
        public EditProfileController (IntPtr handle) : base (handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //var gradientLayer = CustomControls.ButtonBackground(ProfileBackground);
           // ProfileBackground.Layer.InsertSublayer(gradientLayer,0);
        }
    }
}