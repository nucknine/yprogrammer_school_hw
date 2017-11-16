using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Item> Items { get; set; }
    }
}