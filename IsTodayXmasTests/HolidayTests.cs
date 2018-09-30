using IsTodayXmas;
using NUnit.Framework;

namespace IsTodayXmasTests
{
    [TestFixture]
    public class HolidayTests
    {
        [Test]
        public void SayXmasTest_today_is_xmas()
        {
            var holiday = new Holiday();
            Assert.AreEqual("Merry Xmas", holiday.SayXmas());
        }

        [Test]
        public void SayXmasTest_today_is_not_xmas()
        {
            var holiday = new Holiday();
            Assert.AreEqual("Today is not Xmas", holiday.SayXmas());
        }
    }
}