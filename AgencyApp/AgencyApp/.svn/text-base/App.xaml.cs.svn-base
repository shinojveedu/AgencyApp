using AgencyApp.Views;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AgencyApp
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            //Setting the Root page throuth the navigation page class.
            Current.MainPage = new NavigationPage(new DashboardView());

        }
    }
}
