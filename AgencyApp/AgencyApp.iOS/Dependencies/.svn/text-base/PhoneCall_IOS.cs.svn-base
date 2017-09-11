using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using AgencyApp.IDependencies;
using Xamarin.Forms;
using AgencyApp.iOS.Dependencies;

[assembly: Dependency(typeof(PhoneCall_IOS))]
namespace AgencyApp.iOS.Dependencies
{
    class PhoneCall_IOS : IPhoneCall
    {
        public void MakePhoneCall(string phoneNumber)
        {
            try
            {
                NSUrl url = new NSUrl(string.Format(@"telprompt://{0}", phoneNumber));
                UIApplication.SharedApplication.OpenUrl(url);
            }
            catch (Exception ex)
            {
                UIAlertView alert = new UIAlertView();
                alert.Title = "iOS Exception";
                alert.AddButton("OK");
                alert.Message = ex.ToString();
                alert.Show();
            }
        }
    }
}