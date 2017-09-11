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
        Video item;

        public PlayVideo()
        {
            InitializeComponent();
        }

        public PlayVideo(Video item)
        {
            InitializeComponent();
            BindingContext = this.item = item;
        }
    }
}