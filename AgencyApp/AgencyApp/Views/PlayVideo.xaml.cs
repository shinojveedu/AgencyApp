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
	public partial class PlayVideo : ContentPage
	{
        Item item;

        public PlayVideo()
        {
            InitializeComponent();
        }

        public PlayVideo(Item item)
        {
            InitializeComponent();
            BindingContext = this.item = item;
        }
    }
}