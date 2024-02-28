namespace AlarmMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage()
            {
                Children =
                {
                    new AlarmPage(),
                    new TimerPage()
                }
            };
        }
    }
}
