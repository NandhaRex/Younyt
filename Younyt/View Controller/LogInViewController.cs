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
            //var gradientLayer = CustomControls.ButtonBackground(LogInButton);
            var gradientLayer = new CAGradientLayer();
            gradientLayer.Colors = new[] { UIColor.FromRGB(16, 22, 22).CGColor, UIColor.FromRGB(175, 176, 178).CGColor,
            UIColor.FromRGB(16, 22, 22).CGColor};
            gradientLayer.StartPoint = new CGPoint(x: 0, y: 0.5);
            gradientLayer.EndPoint = new CGPoint(x: 1, y: 0.5);
            gradientLayer.CornerRadius = LogInButton.Layer.CornerRadius;
            gradientLayer.Frame = new CGRect(0, 0, LogInButton.Frame.Size.Width, LogInButton.Frame.Size.Height);
            gradientLayer.MasksToBounds = true;
            LogInButton.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}