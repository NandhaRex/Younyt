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
    [Register ("HomeTabController")]
    partial class HomeTabController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITabBar tabbar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (tabbar != null) {
                tabbar.Dispose ();
                tabbar = null;
            }
        }
    }
}