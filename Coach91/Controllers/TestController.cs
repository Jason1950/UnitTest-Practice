using Microsoft.AspNetCore.Mvc;


namespace Coach91.Controllers
{
    /// <summary>
    /// Login: ONEbook.Member.Services.Impl.ProcessLoginService.Login/ Initialization
    /// QRLogin: ONEbook.Member.Services.Impl.ProcessLoginService.Login/ Initialization
    /// Initialize: ONEbook.Member.Services.Impl.ProcessLoginService.Initialization
    /// Logout: ONEbook.Member.Services.Impl.ProcessLoginService.Logout
    /// Checkin: ONEbook.Member.Services.Impl.ProcessLoginService.LoginCheckin
    /// GetESportsWebUrl: ONEbook.Member.Services.Impl.ProcessLoginService.GetESportsWebUrl
    /// ExchangeToken: token service /at/create
    /// DcsSettings: dcs, siteconfig
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private DateTime _today;
        public TestController()
        {
        }
        
        [HttpGet("CheckTodayIsMerryChristmas")]
        public string CheckTodayIsMerryChristmas()
        {
            var today = GetNow();
            if (today.Month == 12 && today.Day == 25)
            {
                return "Merry Xmas";
            }
            return "Today is not Xmas";
        }
        
        public virtual DateTime GetNow()
        {
            return DateTime.Now;
        }
        
    }
    
}