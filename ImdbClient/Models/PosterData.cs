using System;
using System.Collections.Generic;
using System.Text;

namespace ImdbClient.Models
{
    public class PosterData
    {
        public ICollection<PosterDataItem> Posters { get; set; }
        public string ErrorMessage { get; set; }
    }
}
