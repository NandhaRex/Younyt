using Foundation;
using System;
using UIKit;
using Younyt.Custom_Class;

namespace Younyt
{
    public partial class RecommendationViewController : UIViewController
    {
        public RecommendationViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            messageTextView.Layer.BorderColor = UIColor.Gray.CGColor;
            var gradient = CustomControls.ButtonBackground(reccommendationView);
            reccommendationView.Layer.InsertSublayer(gradient, 0);
            reccomendationLabel.Text = "Reccomandations";

            messageTextView.Layer.BorderColor = UIColor.Black.CGColor;
            messageTextView.Layer.BorderWidth = 0.5F;
        }
    }
}