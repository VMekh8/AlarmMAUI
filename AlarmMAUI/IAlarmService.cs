using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMAUI
{
    public interface IAlarmService
    {
        public void SetAlarm(DatePicker datePicker, TimePicker timePicker);
        public void CancelAlarm();
    }
}
