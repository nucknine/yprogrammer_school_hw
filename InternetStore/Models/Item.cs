using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetStore.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        public int CategoryId { get; set; }

        public int ProducerId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ItemArtUrl { get; set; }

        public string ItemDescription { get; set; }

        public Category Category { get; set; }

        public Producer Producer { get; set; }
    }
}