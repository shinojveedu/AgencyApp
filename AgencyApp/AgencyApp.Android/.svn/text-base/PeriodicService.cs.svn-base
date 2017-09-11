using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AgencyApp.Services;
using System.Threading.Tasks;

namespace AgencyApp.Droid
{
    [Service]
    public class PeriodicService : Service
    {
        public override void OnCreate()
        {
            base.OnCreate();

            Toast.MakeText(this, "Notifications Service - Created", ToastLength.Long);
        }

        public override StartCommandResult OnStartCommand(Android.Content.Intent intent, StartCommandFlags flags, int startId)
        {
            GeneralService objService = new GeneralService();
            string clientId = "0";

            if (Xamarin.Forms.Application.Current.Properties.ContainsKey("clientId"))
            {
                clientId = Xamarin.Forms.Application.Current.Properties["clientId"].ToString();
            }

            var notifications = Task.Run(() => objService.GetNotifications(clientId).Result).Result;

            if (notifications.Count > 0)
            {
                int notificationId = 0;
                foreach (var notifcation in notifications)
                {

                    // Instantiate the notification builder and enable sound:
                    Notification.Builder builder = new Notification.Builder(base.BaseContext)
                        .SetContentTitle(notifcation.Subject)
                        .SetContentText(notifcation.Note)
                        .SetDefaults(NotificationDefaults.Vibrate)
                        .SetDefaults(NotificationDefaults.Sound)
                        .SetSmallIcon(Resource.Drawable.logo);

                    // Build the notification:
                    Notification notification = builder.Build();

                    // Get the notification manager:
                    NotificationManager notificationManager =
                        base.BaseContext.GetSystemService(Context.NotificationService) as NotificationManager;

                    // Publish the notification:
                    notificationManager.Notify(notificationId, notification);
                    notificationId++;
                }
            }
            return StartCommandResult.Sticky;
        }

        public override Android.OS.IBinder OnBind(Android.Content.Intent intent)
        {
            Toast.MakeText(this, "Notifications Service - Binded", ToastLength.Long);
            return null;
        }


        public override void OnDestroy()
        {
            //Debug.WriteLine("Notifications Service destroyed");
            base.OnDestroy();
        }

    }
}