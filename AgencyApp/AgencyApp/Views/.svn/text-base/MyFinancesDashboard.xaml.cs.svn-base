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
    }
}