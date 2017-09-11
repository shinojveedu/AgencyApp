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
	public partial class DashboardView : ContentPage
	{
		public DashboardView ()
		{
			InitializeComponent ();

            //Removing the root page's Navigation bar !!!
            //this = current page
            //NavigationPage.SetHasNavigationBar(this, false);

            
        }

        protected override void OnAppearing()
        {
            string clientId = "";

            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Application.Current.Properties["clientId"].ToString();
            }
            txtClientId.Text = "CLIENT ID : " + clientId;
        }

        private void LogOut_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties.Remove("clientId");
            OnAppearing();
        }

        private void CallNow_TapGestureRecognizer_Tapped(object sender, EventArgs e)
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

        private async void MoneyEducation_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MoneyEducation()
            {
                Title = "Money Education"
            });
        }

        private async void MyFinances_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                await Navigation.PushAsync(new MyFinancesDashboard()
                {
                    Title = "My Finances"
                });
            }
            else
            {
                await Navigation.PushAsync(new MyFinances()
                {
                    Title = "My Finances"
                });
            }
            
        }

        private async void AboutUs_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUs()
            {
                Title = "About Us"
            });
        }
    }
}