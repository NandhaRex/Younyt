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
            //var path = UIBezierPath.FromRoundedRect(Bounds, UIRectCorner.TopLeft, new CGSize(30, 30));


            //right side
            //ClipsToBounds = true;
            //Layer.CornerRadius = 10;
            //Layer.MaskedCorners = CACornerMask.MaxXMinYCorner | CACornerMask.MinXMaxYCorner;

            // the offset here is 40 you can play with it to increase / decrease the curve height

            var path = UIBezierPath.FromArc(new CGPoint(Frame.Size.Width - 10, Frame.Size.Height - 10), Frame.Size.Height / 2,
                      180, 315, true);

            var mask = new CAShapeLayer();
            mask.Path = path.CGPath;
            Layer.Mask = mask;

        }
    }
}