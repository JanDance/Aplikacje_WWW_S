using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr5.Models
{
    public class Team
    {
        public int Id {get; set;}
        public string Name {get; set;} = null!;
        public string Country {get;set;} = null!;
        public string City {get; set;} = null!;
        public DateTime FoundingDate {get; set;}

        public int LeagueId {get; set;}
        public virtual League League {get; set;} = null!;

        public virtual ICollection<Match>? Matches {get; set;}
        public virtual ICollection<Player> Players {get; set;} = null!;

    }
}