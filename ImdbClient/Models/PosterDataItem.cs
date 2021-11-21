using System;
using System.Collections.Generic;
using System.Text;

namespace ImdbClient.Models
{
    public partial class PosterDataItem
    {
        public string Link { get; set; }

        public double AspectRatio { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
