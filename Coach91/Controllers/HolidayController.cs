using Microsoft.AspNetCore.Mvc;

namespace Coach91.Controllers;

[ApiController]
public class HolidayController : Controller
{
    private readonly ILogger<HolidayController> _logger;

    [HttpGet("v1/CheckTodayIsMerryChristmas")]
    public string GetTheme()
    {
        var today = GetToday();
        if (today.Month == 12 && today.Day == 25)
        {
            return "Merry Xmas";
        }

        return "Today is not Xmas";
    }

    protected virtual DateTime GetToday()
    {
        return DateTime.Now;
    }
}