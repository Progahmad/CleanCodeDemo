using System;

namespace MoveCode
{
    public class IntroduceExtensionMethod
    {
        public bool CanScheduleEvent()
        {
            bool canSchedule = DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
            return canSchedule;
        }
    }
}
