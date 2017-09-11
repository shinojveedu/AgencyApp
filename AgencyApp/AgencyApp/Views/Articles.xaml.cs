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
	public partial class Articles : ContentPage
	{
		public Articles ()
		{
			InitializeComponent ();

            InitializeArticles();
        }

        private async void InitializeArticles()
        {
            GeneralService objService = new GeneralService();

            List<Models.Articles> actionItems = await objService.GetArticles("Admin");
            ItemsListView.ItemsSource = actionItems;
        }
    }
}