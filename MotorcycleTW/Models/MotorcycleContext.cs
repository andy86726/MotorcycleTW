namespace MotorcycleTW.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MotorcycleContext : DbContext
    {
        public MotorcycleContext()
            : base("name=MotorclcleDB")
        {
        }

        public virtual DbSet<Battery_store> Battery_store { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Classifies> Classifies { get; set; }
        public virtual DbSet<Delivery_way> Delivery_way { get; set; }
        public virtual DbSet<Discounts> Discounts { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Order_Detail> Order_Detail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Product_Feature> Product_Feature { get; set; }
        public virtual DbSet<Product_Picture> Product_Picture { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shopping_Cart> Shopping_Cart { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .HasOptional(e => e.Shopping_Cart)
                .WithRequired(e => e.Products);

            modelBuilder.Entity<Stores>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Stores)
                .HasForeignKey(e => e.Delive_Way_s_id);
        }
    }
}
