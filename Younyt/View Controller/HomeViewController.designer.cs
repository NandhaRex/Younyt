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
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Younyt.CustomLabel homeHeading { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel homeHeadingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView homeTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (homeHeading != null) {
                homeHeading.Dispose ();
                homeHeading = null;
            }

            if (homeHeadingLabel != null) {
                homeHeadingLabel.Dispose ();
                homeHeadingLabel = null;
            }

            if (homeTableView != null) {
                homeTableView.Dispose ();
                homeTableView = null;
            }
        }
    }
}