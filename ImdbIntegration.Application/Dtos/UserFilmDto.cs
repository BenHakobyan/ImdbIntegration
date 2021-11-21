namespace ImdbIntegration.Application.Dtos
{
    public class UserFilmDto : FilmDto
    {
        public int UserId { get; set; }
        public bool IsWatched { get; set; }
    }
}
