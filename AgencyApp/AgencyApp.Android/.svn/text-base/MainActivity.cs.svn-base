using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace AgencyApp.Droid
{
    [Activity(Label = "Agency Application", Theme = "@style/MyTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static Context AppContext;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            AppContext = this.ApplicationContext;

            LoadApplication(new App());

            AppContext.StartService(new Intent(AppContext, typeof(PeriodicService)));

            PendingIntent pintent = PendingIntent.GetService(AppContext, 0, new Intent(AppContext, typeof(PeriodicService)), 0);
            AlarmManager alarm = (AlarmManager)AppContext.GetSystemService(Context.AlarmService);

            alarm.SetRepeating(AlarmType.ElapsedRealtime, SystemClock.ElapsedRealtime() + 120 * 1000, 30 * 1000, pintent);



        }
    }
}