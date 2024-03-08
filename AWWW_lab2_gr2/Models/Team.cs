using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab2_gr2.Models
{
    public class Team
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Country {get; set;}
        public string? City {get; set;}
        public DateTime FoundingDate {get; set;}

        public virtual ICollection<Player> Players {get; set;}
        public virtual League League {get; set;}
    }
}