using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Younyt.Custom_Class
{
    public class CustomControls
    {
        public static CAGradientLayer ButtonBackground(UIView uIView)
        {
            var gradientLayer = new CAGradientLayer();
            gradientLayer.Colors = new[] { UIColor.FromRGB(16, 22, 22).CGColor, UIColor.FromRGB(175, 176, 178).CGColor,
            UIColor.FromRGB(16, 22, 22).CGColor};
            gradientLayer.StartPoint = new CGPoint(x: 0, y: 0.5);
            gradientLayer.EndPoint = new CGPoint(x: 1, y: 0.5);
            gradientLayer.CornerRadius = uIView.Layer.CornerRadius;
            gradientLayer.Frame = uIView.Bounds;
            gradientLayer.MasksToBounds = true;
            return gradientLayer;
        }
    }
}