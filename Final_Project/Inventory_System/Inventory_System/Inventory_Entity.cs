using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Inventory_System
{
    public partial class Inventory_Entity : DbContext
    {
        public Inventory_Entity()
            : base("name=Inventory_Entity")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Measurment> Measurments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transfer_History> Transfer_History { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WH_Prod> WH_Prod { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Website)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Clients)
                .Map(m => m.ToTable("Purchases"));

            modelBuilder.Entity<Measurment>()
                .Property(e => e.Measurment_Unit)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Measurments)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.Prod_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.Product_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Transfer_History)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.Product_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.WH_Prod)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.Product_Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Request>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Request>()
                .Property(e => e.Supplier_Name)
                .IsFixedLength();

            modelBuilder.Entity<Request>()
                .Property(e => e.WH_Name)
                .IsFixedLength();

            modelBuilder.Entity<Request>()
                .Property(e => e.Validity_Period)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Call_Center)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Fax)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Work_Number)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Website)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.Supplier_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer_History>()
                .Property(e => e.Product_Name)
                .IsFixedLength();

            modelBuilder.Entity<Transfer_History>()
                .Property(e => e.From_WH)
                .IsFixedLength();

            modelBuilder.Entity<Transfer_History>()
                .Property(e => e.To_WH)
                .IsFixedLength();

            modelBuilder.Entity<Transfer_History>()
                .Property(e => e.Supplier_Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.User_Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Manager)
                .IsFixedLength();

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.WH_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.WH_Prod)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.WH_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WH_Prod>()
                .Property(e => e.WH_Name)
                .IsFixedLength();
        }
    }
}
