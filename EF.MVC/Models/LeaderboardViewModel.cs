using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF.MVC.Models
{
    public class LeaderboardViewModel
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public string ProfileImageUrl { get; set; }
        public string CountryFlag { get; set; }
    }
}