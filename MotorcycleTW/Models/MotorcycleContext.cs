namespace MotorcycleTW.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MotorcycleContext : DbContext
    {
        public MotorcycleContext()
            : base("name=MotorcycleDB")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Battery_store> Battery_store { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Classifie> Classifies { get; set; }
        public virtual DbSet<Delivery_way> Delivery_way { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order_Detail> Order_Detail { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product_Feature> Product_Feature { get; set; }
        public virtual DbSet<Product_Picture> Product_Picture { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shopping_Cart> Shopping_Cart { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOptional(e => e.Shopping_Cart)
                .WithRequired(e => e.Products);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Stores)
                .HasForeignKey(e => e.Delive_Way_s_id);
        }
    }
}
