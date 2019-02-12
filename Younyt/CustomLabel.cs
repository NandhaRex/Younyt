using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class CustomLabel : UILabel
    {
        public CustomLabel(IntPtr handle) : base(handle)
        {
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            layoutGradient();
        }

        private void layoutGradient()
        {
            var gradientLayer = CustomControls.ButtonBackground(this);
            BackgroundColor = UIColor.Clear;
            Layer.InsertSublayer(gradientLayer, 1);
        }
    }
}