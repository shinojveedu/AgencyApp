using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgencyApp.Models;
using AgencyApp.Services;

namespace AgencyApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Videos : ContentPage
	{
        VideosViewModel videosViewModel;

        public Videos()
        {
            InitializeComponent();

            GetVideo();
            //BindingContext = this.videosViewModel = new VideosViewModel();
        }

        private async void GetVideo()
        {
            GeneralService objService = new GeneralService();
            List<Models.Video> actionItems = await objService.GetVideos("Admin");
            ItemsListView.ItemsSource = actionItems;

        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Video;
            if (item == null)
                return;

            await Navigation.PushAsync(new PlayVideo(item));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }
    }
}