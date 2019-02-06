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
    [Register ("ProfileViewController")]
    partial class ProfileViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EditProfileButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (EditProfileButton != null) {
                EditProfileButton.Dispose ();
                EditProfileButton = null;
            }
        }
    }
}