﻿namespace ImdbIntegration.Application.Dtos
{
    public class WatchListItemDto
    {
        public int UserId { get; set; }
        public string FilmId { get; set; }
        public bool IsWatched { get; set; }
    }
}
