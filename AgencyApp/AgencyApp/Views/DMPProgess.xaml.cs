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
	public partial class DMPProgess : ContentPage
	{
		public DMPProgess ()
		{
			InitializeComponent ();

            InitializeCreditor();
        }

        private async void InitializeCreditor()
        {
            GeneralService objService = new GeneralService();
            string clientId = "0";

            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Application.Current.Properties["clientId"].ToString();
            }
            List<Models.CreditorList> actionItems = await objService.GetCreditorDetails(clientId);
            ItemsListView.ItemsSource = actionItems;
        }
    }
}