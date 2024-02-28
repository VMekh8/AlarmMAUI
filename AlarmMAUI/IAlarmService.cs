using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMAUI
{
    public interface IAlarmService
    {
        public void SetAlarm(int Year, int Month, int Day, int Hours, int Minutes);
        public void CancelAlarm();
    }
}
