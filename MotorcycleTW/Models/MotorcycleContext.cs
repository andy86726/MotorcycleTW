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

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Delivery_way>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Delivery_way)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Members>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Members)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_Detail)
                .WithOptional(e => e.Orders)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Products>()
                .HasOptional(e => e.Shopping_Cart)
                .WithRequired(e => e.Products);
        }
    }
}
