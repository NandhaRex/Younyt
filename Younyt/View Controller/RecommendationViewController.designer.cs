// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Younyt
{
    [Register ("RecommendationViewController")]
    partial class RecommendationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView messageTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel reccomendationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Younyt.CustomLabel reccommendationView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (messageTextView != null) {
                messageTextView.Dispose ();
                messageTextView = null;
            }

            if (reccomendationLabel != null) {
                reccomendationLabel.Dispose ();
                reccomendationLabel = null;
            }

            if (reccommendationView != null) {
                reccommendationView.Dispose ();
                reccommendationView = null;
            }
        }
    }
}