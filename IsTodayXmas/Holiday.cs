using System;

namespace IsTodayXmas
{
    public class Holiday
    {
        public string SayXmas()
        {
            var today = DateTime.Today;
            if (today.Month == 12 && (today.Day == 24 || today.Day == 25))
            {
                return "Merry Xmas";
            }

            return "Today is not Xmas";
        }
    }
}