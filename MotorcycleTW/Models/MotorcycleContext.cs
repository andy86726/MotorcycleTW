using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MotorcycleTW.Models;

namespace MotorcycleTW.Models
{
    public class MotorcycleContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MotorcycleContext() : base("name=MotorcycleContext")
        {
        }

        public System.Data.Entity.DbSet<Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Classify> Classifies { get; set; }
        public System.Data.Entity.DbSet<Store> Stores { get; set; }
        public System.Data.Entity.DbSet<Discount> Discounts { get; set; }
        public System.Data.Entity.DbSet<Member> Members { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public System.Data.Entity.DbSet<Order_Detail> Order_Details { get; set; }
        public System.Data.Entity.DbSet<Payment> Payments { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<Product_Detail> Product_Details { get; set; }
        public System.Data.Entity.DbSet<Product_Feature> Product_Features { get; set; }
        public System.Data.Entity.DbSet<Product_Picture> Product_Pictures { get; set; }
        public System.Data.Entity.DbSet<Shopping_Cart> Shopping_Carts { get; set; }
        public System.Data.Entity.DbSet<Delivery_way> Delivery_Ways { get; set; }
        public System.Data.Entity.DbSet<Battery_store> Battery_Stores { get; set; }
    }
}
