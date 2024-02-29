using Microsoft.Maui.Platform;
using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace AlarmMAUI;

public partial class TimerPage : ContentPage
{
    private Timer timer;
    private TimeSpan time;

    public TimerPage()
	{
		InitializeComponent();

        timer = new Timer(1000);
        timer.Elapsed += Timer_Elapsed;

        ResetTimer();
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        if (time.TotalSeconds > 0)
        {
            time = time.Add(TimeSpan.FromSeconds(-1));
            MainThread.BeginInvokeOnMainThread(() =>
            {
                lblTimer.Text = time.ToString(@"mm\:ss");
            });
        }
        else
        {
            timer.Stop();
        }
    }


    private void OnStartClicked(object sender, EventArgs e)
    {
        timer.Start();
    }

    private void OnStopClicked(object sender, EventArgs e)
    {
        timer.Stop();
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
        timer.Stop();
        ResetTimer();
    }

    private void ResetTimer()
    {
        time = TimeSpan.FromMinutes(60);
        lblTimer.Text = time.ToString(@"mm\:ss");
    }

}