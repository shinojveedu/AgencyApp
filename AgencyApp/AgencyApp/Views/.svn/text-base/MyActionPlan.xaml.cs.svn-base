using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgencyApp.Services;
using AgencyApp.Models;

namespace AgencyApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyActionPlan : ContentPage
	{
		public MyActionPlan ()
		{
			InitializeComponent ();

            InitializeActionPlan();
        }

        private async void InitializeActionPlan()
        {
            GeneralService objService = new GeneralService();
            string clientId = "0";

            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Application.Current.Properties["clientId"].ToString();
            }
            List<ActionItem> actionItems = await objService.GetMyActionPlan(clientId);
            ItemsListView.ItemsSource = actionItems;
        }
    }
}