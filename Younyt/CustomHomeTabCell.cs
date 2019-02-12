using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using UIKit;
using Younyt.Model;

namespace Younyt
{
    public partial class CustomHomeTabCell : UITableViewCell
    {
        public CustomHomeTabCell(IntPtr handle) : base(handle)
        {

        }
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();


            //cardView.Layer.BorderColor = UIColor.Gray.CGColor;
            //cardView.Layer.BorderWidth = 0.2f;

            //var path = UIBezierPath.FromArc(
            //    new CGPoint(bottomBackgroundView.Frame.Size.Width - 5, bottomBackgroundView.Frame.Size.Height - 5),
            //    bottomBackgroundView.Frame.Size.Height / 2, 180, 315, true);

            //var mask = new CAShapeLayer();
            //mask.Path = path.CGPath;
            //bottomBackgroundView.Layer.Mask = mask;


            //cardView.Layer.ShadowColor = UIColor.LightGray.CGColor;
            // cardView.Layer.ShadowOffset = new CGSize(5.0f, 5.0f);
            //cardView.Layer.ShadowRadius = 0.5f;
            // cardView.Layer.ShadowOpacity = 1f;
        }

        internal void UpdateCell(AvatarDetails item)
        {
            avatarName.Text = item.AvatarName;
            avatarCompany.Text = item.AvatarCompany;
        }
    }
}