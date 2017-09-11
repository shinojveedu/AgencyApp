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
	public partial class Notification : ContentPage
	{
		public Notification (bool firstPage)
		{
			InitializeComponent ();

            InitializeNotificationList();

            if(firstPage)
            {
                ToolbarItem itm = new ToolbarItem();
                itm.Text = "Home";
                itm.Order = ToolbarItemOrder.Primary;
                itm.Priority = 1;
                itm.Clicked += new EventHandler(Home_ToolbarItem_Clicked);
                this.ToolbarItems.Add(itm);

            }
        }

        private async void Home_ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DashboardView()
            {
                Title = ""
            });
        }

        private async void InitializeNotificationList()
        {
            GeneralService objService = new GeneralService();
            string clientId = "0";

            if (Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Application.Current.Properties["clientId"].ToString();
            }
            List<Models.NotificationItem> actionItems = await objService.GetNotificationList(clientId);
            ItemsListView.ItemsSource = actionItems;
        }
    }
}