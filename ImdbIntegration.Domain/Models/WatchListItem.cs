﻿using System;

namespace ImdbIntegration.Domain.Models
{
    public class WatchListItem
    {
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public bool IsWatched { get; set; }
        public DateTime? LastOffered { get; set; }
    }
}
