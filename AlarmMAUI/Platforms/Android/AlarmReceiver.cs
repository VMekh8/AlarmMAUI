using Android.App;
using Android.Content;
using AndroidX.Core.App;


namespace AlarmMAUI.Platforms.Android
{
    [BroadcastReceiver(Enabled = true)]
    public class AlarmReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            var notificationIntent = new Intent(context, typeof(MainActivity));
            var contentIntent = PendingIntent.GetActivity(context, 0, notificationIntent, PendingIntentFlags.CancelCurrent);

            var builder = new NotificationCompat.Builder(context)
                .SetAutoCancel(true)
                .SetContentIntent(contentIntent)
                .SetContentTitle("Alarm")
                .SetSmallIcon(Resource.Drawable.abc_dialog_material_background)
                .SetContentText("Your alarm is ringing!");

            var notificationManager = NotificationManagerCompat.From(context);
            notificationManager.Notify(1000, builder.Build());
        }

    }
}
