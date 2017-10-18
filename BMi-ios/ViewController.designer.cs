// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BMi
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateBtt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton detailsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField heightTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel resultLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField weightTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (calculateBtt != null) {
                calculateBtt.Dispose ();
                calculateBtt = null;
            }

            if (detailsButton != null) {
                detailsButton.Dispose ();
                detailsButton = null;
            }

            if (heightTextField != null) {
                heightTextField.Dispose ();
                heightTextField = null;
            }

            if (resultLabel != null) {
                resultLabel.Dispose ();
                resultLabel = null;
            }

            if (weightTextField != null) {
                weightTextField.Dispose ();
                weightTextField = null;
            }
        }
    }
}