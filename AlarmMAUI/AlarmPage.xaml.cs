namespace AlarmMAUI
{
	public partial class AlarmPage : ContentPage
	{
        private IAlarmService _alarmService;
        public AlarmPage(IAlarmService _alarmService)
		{
			InitializeComponent();
			this._alarmService = _alarmService;
		}
	}
}