using System;
using Coach91.Controllers;
using NUnit.Framework;

namespace TestProject1;

// SUT: System Under Test
public class HolidaySonController : HolidayController
{
    private DateTime _today;

    public DateTime Today
    {
        set => _today = value;
    }


    protected override DateTime GetToday()
    {
        return _today;
    }
}

[TestFixture]
public class HolidayControllerTests
{
    [SetUp]
    public void SetUp()
    {
        _holiday = new HolidaySonController();
    }

    private HolidaySonController _holiday;

    [Test]
    public void today_is_xmas()
    {
        GivenToday(12, 25);
        ThemeShouldBe("Merry Xmas");
    }

    [Test]
    public void today_is_not_xmas()
    {
        GivenToday(11, 25);
        ThemeShouldBe("Today is not Xmas");
    }


    private void ThemeShouldBe(string expected)
    {
        var theme = _holiday.GetTheme();
        Assert.AreEqual(expected, theme);
    }

    private static void ThemeShouldBe(string expected, string theme)
    {
        Assert.AreEqual(expected, theme);
    }

    private void GivenToday(int month, int day)
    {
        _holiday.Today = new DateTime(2021, month, day);
    }
}