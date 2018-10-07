using System;
using IsTodayXmas;
using NUnit.Framework;

namespace IsTodayXmasTests
{
    /// <summary>
    /// Passed two tests.
    /// </summary>
    [TestFixture]
    public class HolidayTests
    {
        [Test]
        public void SayXmasTest_today_is_xmas()
        {
            var holiday = new ModifiedHoliday();
            holiday.SetToday(new DateTime(2018, 12, 25));
            Assert.AreEqual("Merry Xmas", holiday.SayXmas());
        }

        [Test]
        public void SayXmasTest_today_is_not_xmas()
        {
            var holiday = new ModifiedHoliday();
            holiday.SetToday(new DateTime(2018, 12, 26));
            Assert.AreEqual("Today is not Xmas", holiday.SayXmas());
        }
    }
}