using System;

namespace IsTodayXmas
{
    /// <summary>
    /// 1. Do not change the signature of method SayXmas.
    /// 2. Do not create a constructor and property of class Holiday.
    /// </summary>
    public class Holiday
    {
        public string SayXmas()
        {
            var today = GetToday();
            if (today.Month == 12 && (today.Day == 24 || today.Day == 25))
            {
                return "Merry Xmas";
            }

            return "Today is not Xmas";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }

    public class ModifiedHoliday : Holiday
    {
        public DateTime _today;

        public void SetToday(DateTime Today)
        {
            _today = Today;
        }

        protected override DateTime GetToday()
        {
            return _today;
        }

    }
}