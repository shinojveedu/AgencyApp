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
	public partial class MyFinancesDashboard : ContentPage
	{
		public MyFinancesDashboard ()
		{
			InitializeComponent ();
		}

        private async void MyAction_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyActionPlan()
            {
                Title = "My Action Plan"
            });
        }

        private async void DMPProcess_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DMPProgess()
            {
                Title = "DMP Progess"
            });
        }


        private async void Recommendations_TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recommendations()
            {
                Title = "Recommendations"
            });
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

        private void CallNow_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            CallContactNumber();
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
                Title = "Financial Education"
            });
        }
    }
}