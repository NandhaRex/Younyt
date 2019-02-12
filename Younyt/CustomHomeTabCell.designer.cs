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
    [Register ("CustomHomeTabCell")]
    partial class CustomHomeTabCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel avatarCompany { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView avatarImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel avatarName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Younyt.TableCellCustomImageView bottomBackgroundView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Younyt.CustomHomeTabCell cardView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (avatarCompany != null) {
                avatarCompany.Dispose ();
                avatarCompany = null;
            }

            if (avatarImage != null) {
                avatarImage.Dispose ();
                avatarImage = null;
            }

            if (avatarName != null) {
                avatarName.Dispose ();
                avatarName = null;
            }

            if (bottomBackgroundView != null) {
                bottomBackgroundView.Dispose ();
                bottomBackgroundView = null;
            }

            if (cardView != null) {
                cardView.Dispose ();
                cardView = null;
            }
        }
    }
}