using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InternetStore.Models
{
    public class StoreEntities : DbContext
    {        
            public DbSet<Producer> Producer { get; set; }
            public DbSet<Item> Items { get; set; }
            public DbSet<Category> Categories { get; set; }
            //public DbSet<Cart> Carts { get; set; }
            //public DbSet<Order> Orders { get; set; }
            //public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}