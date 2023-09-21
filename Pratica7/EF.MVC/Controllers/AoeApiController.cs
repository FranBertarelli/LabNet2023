using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EF.MVC.Controllers
{
    public class AoeApiController : Controller
{
    // GET: AoeApi
    public async Task<ActionResult> Index()
    {
        List<LeaderboardViewModel> leaderboards = await GetLeaderboards();
        return View(leaderboards);
    }

    public async Task<List<LeaderboardViewModel>> GetLeaderboards()
    {
        var client = new HttpClient();

        List<LeaderboardViewModel> leaderboards = null;

        HttpResponseMessage response = await client.GetAsync("https://aoe2.net/api/leaderboard?game=aoe4&start=1&count=10");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            leaderboards = JsonConvert.DeserializeObject<List<LeaderboardViewModel>>(json);
        }
        return leaderboards;
    }
}

public class LeaderboardViewModel
{
    public int Rank { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
}
}