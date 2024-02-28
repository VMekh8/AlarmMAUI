﻿using Android.App;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMAUI.Platforms.Android
{
    public class AlarmService : IAlarmService
    {
        public void SetAlarm(DatePicker datePicker, TimePicker timePicker)
        {
            var alarmTime = new DateTime(datePicker.Date.Year, datePicker.Date.Month, datePicker.Date.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
            var timeSpan = alarmTime - DateTime.Now;
            var alarmIntent = new Intent(global::Android.App.Application.Context, typeof(AlarmReceiver));
            var pendingIntent = PendingIntent.GetBroadcast(global::Android.App.Application.Context, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);
            var alarmManager = (AlarmManager)global::Android.App.Application.Context.GetSystemService(Context.AlarmService);
            alarmManager.SetExactAndAllowWhileIdle(AlarmType.RtcWakeup, Java.Lang.JavaSystem.CurrentTimeMillis() + (long)timeSpan.TotalMilliseconds, pendingIntent);
        }

        public void CancelAlarm()
        {
            var alarmIntent = new Intent(global::Android.App.Application.Context, typeof(AlarmReceiver));
            var pendingIntent = PendingIntent.GetBroadcast(global::Android.App.Application.Context, 0, alarmIntent, PendingIntentFlags.UpdateCurrent);
            var alarmManager = (AlarmManager)global::Android.App.Application.Context.GetSystemService(Context.AlarmService);
            alarmManager.Cancel(pendingIntent);
        }
    }
}
