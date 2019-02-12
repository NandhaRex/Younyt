using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class AboutUsViewController : UIViewController
    {
        public AboutUsViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var gradient = CustomControls.ButtonBackground(gradientView);
            gradientView.Layer.InsertSublayer(gradient, 0);
            aboutLabel.Text = "About Us";
        }
    }
}