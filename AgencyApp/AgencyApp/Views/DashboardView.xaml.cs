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
            this.ToolbarItems.Clear();

            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Application.Current.Properties["clientId"].ToString();

                //  txtClientId.Text = "CLIENT ID : " + clientId;
                NavigationPage.SetHasNavigationBar(this, true);

                ToolbarItem itmClient = new ToolbarItem();
                itmClient.Text = "CLIENT ID : " + clientId;
                itmClient.Order = ToolbarItemOrder.Primary;
                itmClient.Priority = 0;
                this.ToolbarItems.Add(itmClient);

                ToolbarItem itm = new ToolbarItem();
                itm.Text = "Log Out";
                itm.Order = ToolbarItemOrder.Secondary;
                itm.Priority = 1;
                itm.Clicked += new EventHandler(LogOut_ToolbarItem_Clicked);
                this.ToolbarItems.Add(itm);

                ToolbarItem itmNot = new ToolbarItem();
                itmNot.Order = ToolbarItemOrder.Primary;
                itmNot.Priority = 1;
                itmNot.Icon = "notification.png";
                itmNot.Clicked += new EventHandler(Notifications_ToolbarItem_Clicked);
                this.ToolbarItems.Add(itmNot);

            }
            else
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
        }

        private async void Notifications_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notification(false)
            {
                Title = "Notifications"
            });
        }

        private void LogOut_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties.Remove("clientId");
            OnAppearing();
           // this.ToolbarItems.Remove(btnLogout);
        }

        private async void CallContactNumber()
        {
            Services.GeneralService objSer = new Services.GeneralService();
           string numEntry = await objSer.GetContactNummer("Admin");

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

        private void CallNow_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CallContactNumber();

        }

        private async void MoneyEducation_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MoneyEducation()
            {
                Title = "Financial Education"
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