using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgencyApp.Models;

namespace AgencyApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Videos : ContentPage
	{
        VideosViewModel videosViewModel;

        public Videos()
        {
            InitializeComponent();

            BindingContext = this.videosViewModel = new VideosViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new PlayVideo(item));

            // Manually deselect item
            ItemsListView.SelectedItem = null;
        }
    }
}