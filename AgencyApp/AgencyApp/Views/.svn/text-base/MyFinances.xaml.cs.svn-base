using AgencyApp.IDependencies;
using AgencyApp.Services;
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
	public partial class MyFinances : ContentPage
	{
		public MyFinances ()
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

        private void AboutUs_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutUs()
            {
                Title = "About Us"
            });
        }

        private void MoneyEducation_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoneyEducation()
            {
                Title = "Money Education"
            });
        }

        private async void Proceed_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                GeneralService objService = new GeneralService();
                bool IsAuth = await objService.LoginUser(txtClientId.Text,txtSsn.Text);

                if (IsAuth)
                {
                    await Navigation.PushAsync(new MyFinancesDashboard()
                    {
                        Title = "My Finances"
                    });
                     
                    Application.Current.Properties.Remove("clientId");
                    Application.Current.Properties["clientId"] = txtClientId.Text;
                    
                } 
                else
                {
                  await  DisplayAlert("Invalid", "Invalid User", "OK");
                }
            }
            catch(Exception ex)
            {

            }
           
        }
    }
}