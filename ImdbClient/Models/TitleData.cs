namespace ImdbClient.Models
{
    public partial class TitleData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImDbRating { get; set; }
        public PosterData Posters { get; set; }
        public WikipediaData Wikipedia { get; set; }
        public string ErrorMessage { get; set; }
    }
}
