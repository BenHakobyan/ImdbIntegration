using System.Collections.Generic;

namespace ImdbClient.Models
{
    public class SearchData
    {
        public string SearchType { get; set; }
        public string Expression { get; set; }
        public ICollection<SearchResult> Results { get; set; }
        public string ErrorMessage { get; set; }
    }
}
