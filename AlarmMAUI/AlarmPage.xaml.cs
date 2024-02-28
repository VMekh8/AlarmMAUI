namespace AlarmMAUI
{
	public partial class AlarmPage : ContentPage
	{
        private IAlarmService _alarmService;
        public AlarmPage(IAlarmService _alarmService)
		{
			InitializeComponent();
			this._alarmService = _alarmService;

            SetAlarmBtn.Clicked += (s, e) => _alarmService.SetAlarm(DatePicker1.Date.Year, DatePicker1.Date.Month, DatePicker1.Date.Day, TimePicker1.Time.Hours, TimePicker1.Time.Minutes);
            CancelAlarmBtn.Clicked += (s, e) => _alarmService.CancelAlarm();
        }
    }
}