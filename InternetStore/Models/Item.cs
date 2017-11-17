using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InternetStore.Models
{
    [Bind(Exclude="ItemId")]
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ItemId { get; set; }
        [DisplayName("Категория")]
        public int CategoryId { get; set; }
        [DisplayName("Производитель")]
        public int ProducerId { get; set; }
        [Required(ErrorMessage ="Название обязательно")]
        [StringLength(160)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Цена обязательна")]
        [Range(0.1,100, ErrorMessage = "Цена должна быть от 0.1 до 100")]
        public decimal Price { get; set; }
        [DisplayName("Путь к изображению")]
        [StringLength(1024)]
        public string ItemArtUrl { get; set; }

        public string ItemDescription { get; set; }

        public virtual Category Category { get; set; }

        public virtual Producer Producer { get; set; }
    }
}