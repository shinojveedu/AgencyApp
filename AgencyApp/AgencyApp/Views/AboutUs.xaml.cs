using AgencyApp.IDependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgencyApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutUs : ContentPage
	{
		public AboutUs ()
		{
			InitializeComponent ();
		}

        private void CallNow_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            string numEntry = "9447509487";
            try
            {
                if (numEntry == "")
                {
                    DisplayAlert("Alert", "Specify the number to start the call.", "OK");
                }
                else
                {
                    DependencyService.Get<IPhoneCall>().MakePhoneCall(numEntry);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MoneyEducation_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoneyEducation()
            {
                Title = "Money Education"
            });
        }

        private void MyFinances_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyFinances()
            {
                Title = "My Finances"
            });
        }
    }
}