namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelModel : DbContext
    {
        public HotelModel()
            : base("name=HotelMod")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Living> Living { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceCustomers> ServiceCustomers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Living)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ServiceCustomers)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Living>()
                .Property(e => e.SumToPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Living>()
                .Property(e => e.Paid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Living)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.Room_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Reservation)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.serviceName)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceCustomers)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.Scode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Types>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Types>()
                .Property(e => e.dayCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Types>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.Types)
                .HasForeignKey(e => e.type)
                .WillCascadeOnDelete(false);
        }
    }
}
