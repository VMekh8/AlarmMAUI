namespace AlarmMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            IAlarmService _alarmService = DependencyService.Get<IAlarmService>();

            MainPage = new TabbedPage()
            {
                Children =
                {
                    new AlarmPage(_alarmService),
                    new TimerPage()
                }
            };
        }
    }
}
