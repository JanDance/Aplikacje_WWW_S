﻿namespace AWWW_lab1_gr1.Models
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
