using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class LogInViewController : UIViewController
    {
        public LogInViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var gradientLayer = CustomControls.ButtonBackground(LogInButton);
            LogInButton.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}