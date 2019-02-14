using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace Younyt
{
    public partial class TableCellCustomImageView : UIView
    {
        public TableCellCustomImageView(IntPtr handle) : base(handle)
        {
        }
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            //var maskLayer = new CAShapeLayer();
            //maskLayer.Path = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.TopLeft| UIRectCorner.TopRight
            //    , new CoreGraphics.CGSize(20, 10)).CGPath;            
            //Layer.Mask = maskLayer;            

            //Layer.CornerRadius = 15;
            //ClipsToBounds = true;
            //Layer.MaskedCorners = (CACornerMask)7;

            ////left side
            var pathRight = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.BottomRight, new CGSize(30, 30));


            //right side
            ClipsToBounds = true;
            Layer.CornerRadius = 5;
            Layer.MaskedCorners = CACornerMask.MaxXMinYCorner | CACornerMask.MinXMaxYCorner | CACornerMask.MaxXMaxYCorner;

            var mask1 = new CAShapeLayer();
            mask1.Path = pathRight.CGPath;
            Layer.Mask = mask1;
            // the offset here is 40 you can play with it to increase / decrease the curve height

            var path = UIBezierPath.FromArc(new CGPoint(Frame.Size.Width - 5, Frame.Size.Height - 5), Frame.Size.Height / 1.5f,
                      180, 270, true);

            var mask = new CAShapeLayer();
            mask.Path = path.CGPath;
            Layer.Mask = mask;

            //var maskPath = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.BottomLeft | UIRectCorner.TopRight, new CGSize(Frame.Width / 1.5, Frame.Height / 1.5));
            //var maskLayer = new CAShapeLayer();
            //maskLayer.Frame = Bounds;
            //maskLayer.Path = maskPath.CGPath;
            //Layer.Mask = maskLayer;

            //var frame = Frame;
            //var remainder = CGRect.Empty;
            //var slice = CGRect.Empty;

            //frame.Divide(Frame.Height / 2, CGRectEdge.MaxYEdge, out slice, out remainder);
            //var remainder2 = CGRect.Empty;
            //var slice2 = CGRect.Empty;
            //remainder.Divide(remainder.Width / 2, CGRectEdge.MaxXEdge, out slice2, out remainder2);
        }
    }
}