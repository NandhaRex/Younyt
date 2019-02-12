using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class LogInButtonGradient : UIButton
    {
        public LogInButtonGradient(IntPtr handle) : base(handle)
        {
        }
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            layoutGradient();
        }

        private void layoutGradient()
        {
            //Console.WriteLine("Hitted");
            var gradientLayer = CustomControls.ButtonBackground(this);
            Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}