namespace ImdbIntegration.Application.Dtos
{
    public class WatchListItemDto : FilmDto
    {
        public int UserId { get; set; }
        public bool IsWatched { get; set; }
    }
}
