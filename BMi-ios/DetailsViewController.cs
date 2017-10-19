using Foundation;
using System;
using UIKit;

namespace BMi
{
    public partial class DetailsViewController : UIViewController
    {
        public float bmi = 21.5f;

        public DetailsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            EvaluateBMI();
        }

        void EvaluateBMI()
        {
            string result = String.Empty;

            if (bmi <= 16)
                result = "wayy low! Get some mass in there!";
            else if (bmi < 18.5)
                result = "that's kinda low dude...";
            else if (bmi < 25)
                result = "alright, you're good";
            else if (bmi < 30)
                result = "that's high, don't you think?";
            else
                result = "bruh, you need to get back in shape!!";

            detailsLbl.Text = result;
        }
    }
}